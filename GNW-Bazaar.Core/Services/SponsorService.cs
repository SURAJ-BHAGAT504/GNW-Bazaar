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
    public class SponsorService(ILogger<SponsorService> logger, IMapper<SponsorDto, Sponsor> sponsorMapper, IMasterDataClient<Sponsor> sponsorClient, IMapper<Sponsor, SponsorDto> sponsorDtoMapper,
        IConfigurationSettings configuration, IValidationClient validationClient) : ISponsorService
    {
        private const long MaxFileSize = 5 * 1024 * 1024;

        public async Task<ResponseDto<long>> Create(SponsorDto entity)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                var sponsorEntity = sponsorMapper.Map(entity);
                string rootPath = Directory.GetCurrentDirectory();
                DateTime dt = DateTime.Now;

                string sponsorBaseFolder = Path.Combine(rootPath, configuration.GetSponsorImagePath().GetSponsorImagePath);
                string safeClientName = entity.ClientName.Replace(" ", "");

                string uploadFolder = Path.Combine(
                    sponsorBaseFolder,
                    safeClientName,
                    dt.Year.ToString(),
                    dt.ToString("MMM-yyyy"),
                    dt.ToString("dd-MMM")
                );

                string sponsorFilePath = "";
                if (entity.SponsorFile != null)
                {
                    sponsorFilePath = await SaveFile(entity.SponsorFile, uploadFolder);
                }

                var sponsor = new Sponsor
                {
                    ClientName = entity.ClientName,
                    Description = entity.Description,
                    PhoneNumber = entity.PhoneNumber,
                    Email = entity.Email,
                    SponsorType = entity.SponsorType,
                    SponsorFile = sponsorFilePath,
                    StartDate = entity.StartDate,
                    EndDate = entity.EndDate,
                    CreatedBy = entity.CreatedBy,
                    CreatedOn = DateTime.Now,
                    IsActive = true
                };

                var resultId = await sponsorClient.Create(sponsor);

                return new ResponseDto<long>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Sponsor created successfully",
                    Value = resultId
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "SponsorService.Create");
                return new ResponseDto<long>
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<List<SponsorDto>>> Get()
        {
            try
            {
                var sponsors = await sponsorClient.Get();

                var activeSponsors = sponsors
                    .Where(s => DateTime.Now >= s.StartDate &&
                                DateTime.Now <= s.EndDate)
                    .ToList();

                var sponsorDtos = activeSponsors.Select(s => sponsorDtoMapper.Map(s)).ToList();

                return new ResponseDto<List<SponsorDto>>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Sponsors fetched successfully",
                    Value = sponsorDtos
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "SponsorService.Get");
                return new() { ResponseCode = 500, Message = ex.Message };
            }
        }

        public async Task<ResponseDto<SponsorDto?>> Get(long id)
        {
            try
            {
                if (id <= 0) throw new Exception("Please enter a valid Id");

                var sponsor = await sponsorClient.Get(id) ?? throw new Exception($"No sponsor found with Id {id}");
                var dto = sponsorDtoMapper.Map(sponsor);

                return new ResponseDto<SponsorDto?>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Sponsor fetched successfully",
                    Value = dto
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "SponsorService.GetById");
                return new() { ResponseCode = (int)HttpStatusCode.InternalServerError, Message = ex.Message };
            }
        }

        public async Task<ResponseDto<bool>> Update(SponsorDto entity)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);
                if (entity.Id == 0) throw new Exception("Please enter valid Id");

                var existingSponsor = await sponsorClient.Get(entity.Id) ?? throw new Exception("Sponsor not found");

                string sponsorFilePath = existingSponsor.SponsorFile;

                if (entity.SponsorFile != null)
                {
                    if (File.Exists(existingSponsor.SponsorFile))
                        File.Delete(existingSponsor.SponsorFile);

                    string rootPath = Directory.GetCurrentDirectory();
                    DateTime dt = DateTime.Now;
                    string uploadFolder = Path.Combine(rootPath, configuration.GetSponsorImagePath().GetSponsorImagePath, entity.ClientName.Replace(" ", ""), dt.ToString("yyyy-MM-dd"));

                    sponsorFilePath = await SaveFile(entity.SponsorFile, uploadFolder);
                }

                existingSponsor.ClientName = entity.ClientName;
                existingSponsor.Description = entity.Description;
                existingSponsor.PhoneNumber = entity.PhoneNumber;
                existingSponsor.Email = entity.Email;
                existingSponsor.SponsorType = entity.SponsorType;
                existingSponsor.SponsorFile = sponsorFilePath;
                existingSponsor.StartDate = entity.StartDate;
                existingSponsor.EndDate = entity.EndDate;
                existingSponsor.UpdatedOn = DateTime.Now;

                await sponsorClient.Update(existingSponsor);

                return new ResponseDto<bool> { ResponseCode = (int)HttpStatusCode.OK, Message = "Sponsor updated successfully", Value = true };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "SponsorService.Update");
                return new() { ResponseCode = (int)HttpStatusCode.InternalServerError, Message = ex.Message };
            }
        }

        public async Task<ResponseDto<List<SponsorDto>>> GetByEmail(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                {
                    throw new Exception("Email is required to fetch sponsors.");
                }

                var sponsors = await validationClient.GetSponsoeClient(email);

                var sponsorDtos = new List<SponsorDto>();

                if (sponsors != null && sponsors.Any())
                {
                    sponsorDtos = sponsors.Select(s => sponsorDtoMapper.Map(s)).ToList();
                }

                return new ResponseDto<List<SponsorDto>>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = sponsorDtos.Any()
                        ? "Sponsors fetched successfully"
                        : "No sponsors found for the provided email",
                    Value = sponsorDtos
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "SponsorService.GetByEmail");
                return new ResponseDto<List<SponsorDto>>
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        //public async Task<ResponseDto<bool>> RecordFrequency(long sponsorId)
        //{
        //    try
        //    {
        //        var sponsor = await sponsorClient.Get(sponsorId);

        //        if (sponsor == null)
        //            return new ResponseDto<bool> { ResponseCode = (int)HttpStatusCode.NotFound, Message = "Sponsor not found", Value = false };

        //        if (sponsor.Frequency > 0)
        //        {
        //            sponsor.Frequency -= 1;
        //            sponsor.UpdatedOn = DateTime.Now;
        //            await sponsorClient.Update(sponsor);
        //        }

        //        return new ResponseDto<bool>
        //        {
        //            ResponseCode = (int)HttpStatusCode.OK,
        //            Message = "Frequency recorded",
        //            Value = true
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.LogError(ex, "SponsorService.RecordFrequency");
        //        return new ResponseDto<bool> { ResponseCode = (int)HttpStatusCode.InternalServerError, Message = ex.Message };
        //    }
        //}

        private async Task<string> SaveFile(IFormFile file, string folder)
        {
            if (file.Length > MaxFileSize) throw new Exception($"File size exceeds {MaxFileSize / 1024 / 1024} MB limit");

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            string fileName = $"{Guid.NewGuid()}_{Path.GetFileName(file.FileName)}";
            string filePath = Path.Combine(folder, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return filePath;
        }

        public async Task<ResponseDto<List<SponsorDto>>> GetByAdmin()
        {
            try
            {
                var sponsors = await sponsorClient.Get();
                var sponsorDtos = sponsors?.Select(s => sponsorDtoMapper.Map(s)).ToList() ?? new List<SponsorDto>();

                return new ResponseDto<List<SponsorDto>>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Sponsors fetched successfully",
                    Value = sponsorDtos
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "SponsorService.GetByAdmin");
                return new() { ResponseCode = (int)HttpStatusCode.InternalServerError, Message = ex.Message };
            }
        }
    }
}