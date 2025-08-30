using GNW_Bazaar.Core.Interface;
using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace GNW_Bazaar.Core.Services
{
    public class UserService(ILogger<UserService> logger, IMapper<UserDto, User> userMapper, IValidationClient validationClient,
        IMasterDataClient<User> userClient, IMapper<User, UserDto> userDtoMapper) : IMasterDataService<UserDto>
    {
        public async Task<ResponseDto<long>> Create(UserDto entity)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                var userEntity = userMapper.Map(entity);

                var userExist = await validationClient.GetUser(entity.Email);

                if (userExist != null) throw new Exception("User already exists");

                var passwordHasher = new PasswordHasher<UserDto>();
                entity.Password = passwordHasher.HashPassword(entity, entity.Password);

                entity.CreatedOn = DateTime.Now;

                entity.Id = await userClient.Create(userMapper.Map(entity));

                return new ResponseDto<long>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "User created successfully",
                    Value = entity.Id
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "UserService.Create");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<List<UserDto>>> Get()
        {
            try
            {
                var user = await userClient.Get();

                var userDtos = new List<UserDto>();

                if (user != null && user.Any())
                {
                    userDtos = user.Select(user => userDtoMapper.Map(user)).ToList();
                }

                return new()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Users fetched successfully",
                    Value = userDtos
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "UserService.Get");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<UserDto?>> Get(long id)
        {
            try
            {
                if (id == 0) throw new Exception("Please enter valid Id");

                var user = await userClient.Get(id) ?? throw new Exception($"No user found with Id {id}");

                var userDto = userDtoMapper.Map(user);

                return new()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "User fetched successfully",
                    Value = userDto
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "UserService.Get");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<bool>> Update(UserDto entity)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                if (entity.Id == 0) throw new Exception("Please enter valid Id");

                entity.UpdatedOn = DateTime.Now;

                await userClient.Update(userMapper.Map(entity));

                return new ResponseDto<bool>()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "User updated successfully",
                    Value = true
                };

            }
            catch (Exception ex)
            {
                logger.LogError(ex, "UserService.Update");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }
    }
}
