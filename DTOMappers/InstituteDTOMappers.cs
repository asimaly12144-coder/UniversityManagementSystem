using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class InstituteDTOMappers
    {
        // Create Institute DTO Mapper
        public static Institute InstituteDTOToEntityMapper(InstituteRequestDTO dto)
        {
            Institute institute = new Institute();
            institute.InstituteName = dto.InstituteName;
            institute.Description = dto.Description;
            institute.Code = dto.Code;
            institute.EstablishIn = dto.EstablishIn;
            institute.FacultyCampusId = dto.FacultyCampusId;
            institute.IsActive = true;
            return institute;
        }

        // Edit Institute DTO Mapper
        public static Institute InstituteDTOToEditEntityMapper(Institute institute, InstituteRequestDTO dto)
        {
            institute.InstituteName = dto.InstituteName;
            institute.Description = dto.Description;
            institute.Code = dto.Code;
            institute.EstablishIn = dto.EstablishIn;
            institute.FacultyCampusId = dto.FacultyCampusId;
            institute.UpdatedAt = DateTime.Now;
            return institute;
        }

        // Entity to Response DTO
        public static InstituteResponseDTO EntityToInstituteDTO(Institute institute)
        {
            InstituteResponseDTO dto = new InstituteResponseDTO();
            dto.Id = institute.Id;
            dto.InstituteName = institute.InstituteName;
            dto.Description = institute.Description;
            dto.Code = institute.Code;
            dto.FacultyCampusId = institute.FacultyCampusId;
            dto.EstablishIn=institute.EstablishIn;
            dto.IsActive = institute.IsActive;
            dto.GlobalId = institute.GlobalId;
            dto.CreatedAt = institute.CreatedAt;
            dto.UpdatedAt = institute.UpdatedAt;
            dto.DeletedAt = institute.DeletedAt;
            dto.CreatedBy = institute.CreatedBy;
            dto.UpdatedBy = institute.UpdatedBy;
            dto.DeletedBy = institute.DeletedBy;

            return dto;
        }

        // List of InstituteResponseDTO Mapper
        public static List<InstituteResponseDTO> EntitiesToInstituteDTOs(List<Institute> institutes)
        {
            List<InstituteResponseDTO> responseList = new List<InstituteResponseDTO>();
            foreach (Institute institute in institutes)
            {
                InstituteResponseDTO dto = EntityToInstituteDTO(institute);
                responseList.Add(dto);
            }
            return responseList;
        }
    }
}
