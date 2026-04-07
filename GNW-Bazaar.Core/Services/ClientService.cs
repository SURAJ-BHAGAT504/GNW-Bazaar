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
        IMapper<Client, ClientDto> clientDtoMapper, IConfigurationSettings configuration, IMasterDataClient<SubCategoryMaster> subCategoryMasterClient) : IClientService
    {
        private const long MaxFileSize = 5 * 1024 * 1024;

        public async Task<ResponseDto<long>> Create(ClientDto entity, string rootPath)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                var clientEntity = clientMapper.Map(entity);

                DateTime dt = DateTime.Now;

                string clientBaseFolder = Path.Combine(rootPath, configuration.GetClientImagePath().ClientImagePath);
                string safeName = clientEntity.ClientName.Replace(" ", "");

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
                    ClientName = clientEntity.ClientName,
                    subCategoryMasters = new List<SubCategoryMaster>(),
                    Highlights = clientEntity.Highlights,
                    PhoneNumber = clientEntity.PhoneNumber,
                    WhatsAppNumber = clientEntity.WhatsAppNumber,
                    Address = clientEntity.Address,
                    Location = clientEntity.Location,
                    ClientImage = clientImagePath,
                    EndDate = clientEntity.EndDate,
                    IsActive = true,
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now
                };

                if (entity.SubCategoryMasterIds != null && entity.SubCategoryMasterIds.Any())
                {
                    foreach (var subCatId in entity.SubCategoryMasterIds)
                    {
                        var category = await subCategoryMasterClient.Get(subCatId);
                        if (category != null)
                        {
                            client.subCategoryMasters.Add(category);
                        }
                    }
                }

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

                var clientDtos = new List<ClientDto>();

                if (clients != null && clients.Any())
                {
                    clientDtos = clients.Select(c => clientDtoMapper.Map(c)).ToList();
                }

                return new()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Clients fetched successfully",
                    Value = clientDtos
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "ClientService.Get");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
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

        public async Task<ResponseDto<bool>> Update(ClientDto entity, string rootPath)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                if (entity.Id == 0) throw new Exception("Please enter valid Id");

                var existingClient = await clientDataClient.Get(entity.Id);

                if (existingClient == null) throw new Exception("Client not found");

                string clientImageFolder;

                if (!string.IsNullOrEmpty(existingClient.ClientImage))
                {
                    clientImageFolder = Path.GetDirectoryName(Path.Combine(rootPath, existingClient.ClientImage))!;
                }
                else
                {
                    DateTime dt = DateTime.Now;
                    clientImageFolder = Path.Combine(rootPath, configuration.GetClientImagePath().ClientImagePath,
                        entity.ClientName.Replace(" ", ""), "ClientImage", dt.Year.ToString(), dt.ToString("MMM-yyyy"), dt.ToString("dd-MMM"));
                }

                string clientImagePath = existingClient.ClientImage;

                if (entity.ClientImage != null)
                {
                    if (!string.IsNullOrEmpty(existingClient.ClientImage))
                    {
                        var oldClientImagePath = Path.Combine(rootPath, existingClient.ClientImage);
                        if (File.Exists(oldClientImagePath))
                            File.Delete(oldClientImagePath);
                    }

                    clientImagePath = await SaveFile(entity.ClientImage, clientImageFolder);
                }

                existingClient.ClientName = entity.ClientName;
                existingClient.Highlights = entity.Highlights;
                existingClient.PhoneNumber = entity.PhoneNumber;
                existingClient.WhatsAppNumber = entity.WhatsAppNumber;
                existingClient.Address = entity.Address;
                existingClient.Location = entity.Location;
                existingClient.ClientImage = clientImagePath;
                existingClient.EndDate = entity.EndDate;
                existingClient.IsActive = entity.IsActive;
                existingClient.UpdatedOn = DateTime.Now;

                existingClient.subCategoryMasters.Clear();

                if (entity.SubCategoryMasterIds != null && entity.SubCategoryMasterIds.Any())
                {
                    foreach (var subCatId in entity.SubCategoryMasterIds)
                    {
                        var category = await subCategoryMasterClient.Get(subCatId);
                        if (category != null)
                        {
                            existingClient.subCategoryMasters.Add(category);
                        }
                    }
                }

                await clientDataClient.Update(existingClient);

                return new ResponseDto<bool> { ResponseCode = (int)HttpStatusCode.OK, Message = "Client updated successfully", Value = true };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "ClientService.Update");
                return new() { ResponseCode = (int)HttpStatusCode.InternalServerError, Message = ex.Message };
            }
        }

        private async Task<string> SaveFile(IFormFile file, string folder)
        {
            try
            {
                if (file.Length > MaxFileSize) throw new Exception($"File size exceeds {MaxFileSize / 1024 / 1024} MB limit");

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                string fileName = Path.GetFileName(file.FileName);
                string filePath = Path.Combine(folder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                return filePath;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "ClientService.SaveFile");
                throw new Exception("Error while saving file: " + ex.Message);
            }
        }
    }
}