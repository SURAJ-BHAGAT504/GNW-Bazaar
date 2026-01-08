using GNW_Bazaar.Core.Interface;
using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace GNW_Bazaar.Core.Services
{
    public class ClientService(ILogger<ClientService> logger, IMapper<ClientDto, Client> clientMapper, IValidationClient validationClient, IMasterDataClient<Client> clientDataClient,
        IMapper<Client, ClientDto> clientDtoMapper,
        IConfigurationSettings configuration) : IMasterDataService<ClientDto>
    {
        private const long MaxFileSize = 5 * 1024 * 1024;

        public async Task<ResponseDto<long>> Create(ClientDto entity)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                var clientExist = await validationClient.GetClient(entity.Email);

                if (clientExist != null) throw new Exception("Client with this email already exists");

                var clientEntity = clientMapper.Map(entity);

                string rootPath = Directory.GetCurrentDirectory();
                DateTime dt = DateTime.Now;

                string clientBaseFolder = Path.Combine(rootPath, configuration.GetClientImagePath().ClientImagePath);
                string safeName = entity.ClientName.Replace(" ", "");

                string clientImageFolder = Path.Combine(
                    clientBaseFolder,
                    safeName,
                    "ClientImage",
                    dt.Year.ToString(),
                    dt.ToString("MMM-yyyy"),
                    dt.ToString("dd-MMM")
                );

                if (!Directory.Exists(clientImageFolder))
                    Directory.CreateDirectory(clientImageFolder);

                string clientImagePath = "";

                if (entity.ClientImage != null)
                    clientImagePath = await SaveFile(entity.ClientImage, clientImageFolder);

                var client = new Client
                {
                    ClientName = entity.ClientName,
                    CategoryMasterId = entity.CategoryMasterId,
                    ContactPerson = entity.ContactPerson,
                    PhoneNumber = entity.PhoneNumber,
                    Email = entity.Email,
                    Address = entity.Address,
                    Location = entity.Location,
                    ClientImage = clientImagePath,
                    IsActive = true,
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now
                };

                await clientDataClient.Create(client);

                return new ResponseDto<long>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Client created successfully",
                    Value = client.Id
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "ClientService.Create");
                return new ResponseDto<long>
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }

        public async Task<ResponseDto<List<ClientDto>>> Get()
        {
            try
            {
                var clients = await clientDataClient.Get();
                var clientDtos = clients?.Select(c => clientDtoMapper.Map(c)).ToList() ?? new List<ClientDto>();

                return new ResponseDto<List<ClientDto>>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Clients fetched successfully",
                    Value = clientDtos
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "ClientService.Get");
                return new ResponseDto<List<ClientDto>>
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                    Value = new List<ClientDto>()
                };
            }
        }

        public async Task<ResponseDto<ClientDto?>> Get(long id)
        {
            try
            {
                if (id == 0) throw new Exception("Invalid Id");

                var client = await clientDataClient.Get(id) ?? throw new Exception($"No client found with Id {id}");
                var clientDto = clientDtoMapper.Map(client);

                return new ResponseDto<ClientDto?>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Client fetched successfully",
                    Value = clientDto
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "ClientService.Get");
                return new ResponseDto<ClientDto?>
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<bool>> Update(ClientDto entity)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                if (entity.Id == 0) throw new Exception("Invalid Id");

                var existingClient = await clientDataClient.Get(entity.Id) ?? throw new Exception("Client not found");

                string clientImagePath = existingClient.ClientImage;

                if (entity.ClientImage != null)
                {
                    string clientImageFolder;

                    if (!string.IsNullOrEmpty(existingClient.ClientImage))
                    {
                        clientImageFolder = Path.GetDirectoryName(existingClient.ClientImage)!;
                    }
                    else
                    {
                        DateTime dt = DateTime.Now;
                        string rootPath = Directory.GetCurrentDirectory();
                        string clientBaseFolder = Path.Combine(rootPath, configuration.GetClientImagePath().ClientImagePath);
                        string safeName = entity.ClientName.Replace(" ", "");

                        clientImageFolder = Path.Combine(
                            clientBaseFolder,
                            safeName,
                            "ClientImage",
                            dt.Year.ToString(),
                            dt.ToString("MMM-yyyy"),
                            dt.ToString("dd-MMM")
                        );
                    }

                    if (File.Exists(existingClient.ClientImage))
                    {
                        File.Delete(existingClient.ClientImage);
                    }

                    clientImagePath = await SaveFile(entity.ClientImage, clientImageFolder);
                }

                existingClient.ClientName = entity.ClientName;
                existingClient.CategoryMasterId = entity.CategoryMasterId;
                existingClient.ContactPerson = entity.ContactPerson;
                existingClient.PhoneNumber = entity.PhoneNumber;
                existingClient.Email = entity.Email;
                existingClient.Address = entity.Address;
                existingClient.Location = entity.Location;
                existingClient.ClientImage = clientImagePath;
                existingClient.IsActive = entity.IsActive;
                existingClient.UpdatedOn = DateTime.Now;

                await clientDataClient.Update(existingClient);

                return new ResponseDto<bool>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Client updated successfully",
                    Value = true
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "ClientService.Update");
                return new ResponseDto<bool>
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                    Value = false
                };
            }
        }

        private async Task<string> SaveFile(IFormFile file, string folder)
        {
            if (file.Length > MaxFileSize) throw new Exception("File size exceeds 5MB limit");

            if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

            string fileName = $"{Guid.NewGuid()}_{Path.GetFileName(file.FileName)}";
            string filePath = Path.Combine(folder, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return filePath;
        }
    }
}