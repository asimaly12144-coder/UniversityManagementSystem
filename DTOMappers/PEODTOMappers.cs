using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class PEODTOMappers
    {
        // Create PEO DTO Mapper
        public static ProgramEductionOutcomes PeoDTOToEntityMapper(PeoRequestDTO dto)
        {
            ProgramEductionOutcomes peo = new ProgramEductionOutcomes();
            peo.PEOName = dto.PEOName;
            peo.Description = dto.Description;
            peo.Code = dto.Code;
            peo.DegreeProgramId = dto.DegreeProgramId;
            peo.IsActive = true;
            return peo;
        }

        // Edit PEO DTO Mapper
        public static ProgramEductionOutcomes PeoDTOToEditEntityMapper(ProgramEductionOutcomes peo, PeoRequestDTO dto)
        {
            peo.PEOName = dto.PEOName;
            peo.Description = dto.Description;
            peo.Code = dto.Code;
            peo.DegreeProgramId = dto.DegreeProgramId;
            peo.UpdatedAt = DateTime.Now;
            return peo;
        }

        // Entity to Response DTO
        public static PeoResponseDTO EntityToPeoDTO(ProgramEductionOutcomes peo)
        {
            PeoResponseDTO dto = new PeoResponseDTO();
            dto.Id = peo.Id;
            dto.PEOName = peo.PEOName;
            dto.Description = peo.Description;
            dto.Code = peo.Code;
            dto.DegreeProgramId = peo.DegreeProgramId;

            dto.IsActive = peo.IsActive;
            dto.GlobalId = peo.GlobalId;
            dto.CreatedAt = peo.CreatedAt;
            dto.UpdatedAt = peo.UpdatedAt;
            dto.DeletedAt = peo.DeletedAt;
            dto.CreatedBy = peo.CreatedBy;
            dto.UpdatedBy = peo.UpdatedBy;
            dto.DeletedBy = peo.DeletedBy;

            return dto;
        }

        // List of PeoResponseDTO Mapper
        public static List<PeoResponseDTO> EntitiesToPeoDTOs(List<ProgramEductionOutcomes> peos)
        {
            List<PeoResponseDTO> responseList = new List<PeoResponseDTO>();
            foreach (ProgramEductionOutcomes peo in peos)
            {
                PeoResponseDTO dto = EntityToPeoDTO(peo);
                responseList.Add(dto);
            }
            return responseList;
        }
    }
}
