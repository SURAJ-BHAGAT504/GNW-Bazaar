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
    public class DoctorService(ILogger<DoctorService> logger, IMapper<DoctorDto, Doctor> doctorMapper, IValidationClient validationClient,
        IDoctorClient doctorClient, IMapper<Doctor, DoctorDto> doctorDtoMapper, IConfigurationSettings configuration, IMasterDataClient<HealthCareCategory> healthcareCategoryClient) : IDoctorService
    {
        private const long MaxFileSize = 5 * 1024 * 1024;

        public async Task<ResponseDto<long>> Create(DoctorDto entity, string rootPath)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                var doctorEntity = doctorMapper.Map(entity);

                DateTime dt = DateTime.Now;

                string doctorBaseFolder = Path.Combine(rootPath, configuration.GetHealthCareImagePath().DoctorImagePath);
                string clinicBaseFolder = Path.Combine(rootPath, configuration.GetHealthCareImagePath().ClinicImagePath);

                string safeName = doctorEntity.DoctorName.Replace(" ", "");

                string doctorImageFolder = Path.Combine(
                    doctorBaseFolder,
                    safeName,
                    "DoctorImage",
                    dt.Year.ToString(),
                    dt.ToString("MMM-yyyy"),
                    dt.ToString("dd-MMM")
                );

                string clinicImageFolder = Path.Combine(
                    clinicBaseFolder,
                    safeName,
                    "ClinicImage",
                    dt.Year.ToString(),
                    dt.ToString("MMM-yyyy"),
                    dt.ToString("dd-MMM")
                );

                if (!Directory.Exists(doctorImageFolder))
                    Directory.CreateDirectory(doctorImageFolder);

                if (!Directory.Exists(clinicImageFolder))
                    Directory.CreateDirectory(clinicImageFolder);

                string doctorImagePath = "";
                string clinicImagePath = "";

                if (entity.DoctorImage != null)
                    doctorImagePath = await SaveFile(entity.DoctorImage, doctorImageFolder);

                if (entity.ClinicImage != null)
                    clinicImagePath = await SaveFile(entity.ClinicImage, clinicImageFolder);

                var doctor = new Doctor
                {
                    DoctorName = doctorEntity.DoctorName,
                    healthCareCategory = new List<HealthCareCategory>(),
                    AboutDoctor = doctorEntity.AboutDoctor,
                    Phonenumber = doctorEntity.Phonenumber,
                    WhatsAppNumber = doctorEntity.WhatsAppNumber,
                    Address = doctorEntity.Address,
                    Location = doctorEntity.Location,
                    DoctorImage = doctorImagePath,
                    ClinicImage = clinicImagePath,
                    EndDate = doctorEntity.EndDate,
                    IsActive = true,
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now
                };

                if (entity.HealthCareCategoryIds != null && entity.HealthCareCategoryIds.Any())
                {
                    foreach (var HCatId in entity.HealthCareCategoryIds)
                    {
                        var category = await healthcareCategoryClient.Get(HCatId);
                        if (category != null)
                        {
                            doctor.healthCareCategory.Add(category);
                        }
                    }
                }

                await doctorClient.Create(doctor);

                return new ResponseDto<long>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Doctor created successfully",
                    Value = entity.Id
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "DoctorService.Create");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<List<DoctorDto>>> Get()
        {
            try
            {
                var doctor = await doctorClient.Get();

                var doctorDtos = new List<DoctorDto>();

                if (doctor != null && doctor.Any())
                {
                    doctorDtos = doctor.Select(doctor => doctorDtoMapper.Map(doctor)).ToList();
                }

                return new()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Doctors fetched successfully",
                    Value = doctorDtos
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "DoctorService.Get");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<DoctorDto?>> Get(long id)
        {
            try
            {
                if (id == 0) throw new Exception("Please enter valid Id");

                var doctor = await doctorClient.Get(id) ?? throw new Exception($"No doctor found with Id {id}");

                var doctorDto = doctorDtoMapper.Map(doctor);

                return new()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Doctor fetched successfully",
                    Value = doctorDto
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "DoctorService.Get");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<List<DoctorDto>>> GetDoctorByCategoryId(long subCategoryId)
        {
            try
            {
                if (subCategoryId == 0) throw new Exception("Please enter valid SubCategoryId");

                var doctor = await doctorClient.GetDoctorByCategoryId(subCategoryId) ?? throw new Exception($"No doctor found with subcategory Id {subCategoryId}");

                var doctorDtos = new List<DoctorDto>();

                if (doctor != null && doctor.Any())
                {
                    doctorDtos = doctor.Select(doctor => doctorDtoMapper.Map(doctor)).ToList();
                }
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Doctor fetched successfully",
                    Value = doctorDtos
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "DoctorService.GetDoctorBySubCategoryId");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<bool>> Update(DoctorDto entity, string rootPath)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                if (entity.Id == 0) throw new Exception("Please enter valid Id");

                var existingDoctor = await doctorClient.Get(entity.Id);

                if (existingDoctor == null) throw new Exception("Doctor not found");

                string doctorImageFolder;

                if (!string.IsNullOrEmpty(existingDoctor.DoctorImage))
                {
                    doctorImageFolder = Path.GetDirectoryName(Path.Combine(rootPath, existingDoctor.DoctorImage));
                }
                else
                {
                    DateTime dt = DateTime.Now;
                    doctorImageFolder = Path.Combine(rootPath, configuration.GetHealthCareImagePath().DoctorImagePath,
                        entity.DoctorName.Replace(" ", ""), "DoctorImage", dt.Year.ToString(), dt.ToString("MMM-yyyy"), dt.ToString("dd-MMM"));
                }

                string clinicImageFolder;

                if (!string.IsNullOrEmpty(existingDoctor.ClinicImage))
                {
                    clinicImageFolder = Path.GetDirectoryName(Path.Combine(rootPath, existingDoctor.ClinicImage));
                }
                else
                {
                    DateTime dt = DateTime.Now;
                    clinicImageFolder = Path.Combine(rootPath, configuration.GetHealthCareImagePath().ClinicImagePath,
                        entity.DoctorName.Replace(" ", ""), "ClinicImage", dt.Year.ToString(), dt.ToString("MMM-yyyy"), dt.ToString("dd-MMM"));
                }

                string doctorImagePath = existingDoctor.DoctorImage;
                string clinicImagePath = existingDoctor.ClinicImage;

                if (entity.DoctorImage != null)
                {
                    if (!string.IsNullOrEmpty(existingDoctor.DoctorImage))
                    {
                        var oldDoctorImagePath = Path.Combine(rootPath, existingDoctor.DoctorImage);
                        if (File.Exists(oldDoctorImagePath))
                            File.Delete(oldDoctorImagePath);
                    }

                    doctorImagePath = await SaveFile(entity.DoctorImage, doctorImageFolder);
                }

                if (entity.ClinicImage != null)
                {
                    if (!string.IsNullOrEmpty(existingDoctor.ClinicImage))
                    {
                        var oldClinicImagePath = Path.Combine(rootPath, existingDoctor.ClinicImage);
                        if (File.Exists(oldClinicImagePath))
                            File.Delete(oldClinicImagePath);
                    }

                    clinicImagePath = await SaveFile(entity.ClinicImage, clinicImageFolder);
                }

                existingDoctor.DoctorName = entity.DoctorName;
                existingDoctor.AboutDoctor = entity.AboutDoctor;
                existingDoctor.Phonenumber = entity.Phonenumber;
                existingDoctor.WhatsAppNumber = entity.WhatsAppNumber;
                existingDoctor.Address = entity.Address;
                existingDoctor.Location = entity.Location;
                existingDoctor.DoctorImage = doctorImagePath;
                existingDoctor.ClinicImage = clinicImagePath;
                existingDoctor.EndDate = entity.EndDate;
                existingDoctor.IsActive = entity.IsActive;
                existingDoctor.UpdatedOn = DateTime.Now;

                existingDoctor.healthCareCategory.Clear();

                if (entity.HealthCareCategoryIds != null && entity.HealthCareCategoryIds.Any())
                {
                    foreach (var HCatId in entity.HealthCareCategoryIds)
                    {
                        var category = await healthcareCategoryClient.Get(HCatId);
                        if (category != null)
                        {
                            existingDoctor.healthCareCategory.Add(category);
                        }
                    }
                }

                await doctorClient.Update(existingDoctor);

                return new ResponseDto<bool> { ResponseCode = (int)HttpStatusCode.OK, Message = "Doctor updated successfully", Value = true };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "DoctorService.Update");
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
                logger.LogError(ex, "DoctorService.SaveFile");
                throw new Exception("Error while saving file: " + ex.Message);
            }
        }
    }
}
