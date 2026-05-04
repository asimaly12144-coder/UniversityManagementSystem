using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class PLODTOMappers
    {
        // Create PLO DTO Mapper
        public static ProgramLearningOutcomes PloDTOToEntityMapper(PloRequestDTO dto)
        {
            ProgramLearningOutcomes plo = new ProgramLearningOutcomes();
            plo.PLOName = dto.PLOName;
            plo.Description = dto.Description;
            plo.Code = dto.Code;
            plo.DegreeProgramId = dto.DegreeProgramId;
            plo.IsActive = true;
            return plo;
        }

        // Edit PLO DTO Mapper
        public static ProgramLearningOutcomes PloDTOToEditEntityMapper(ProgramLearningOutcomes plo, PloRequestDTO dto)
        {
            plo.PLOName = dto.PLOName;
            plo.Description = dto.Description;
            plo.Code = dto.Code;
            plo.DegreeProgramId = dto.DegreeProgramId;
            plo.UpdatedAt = DateTime.Now;
            return plo;
        }

        // Entity to Response DTO
        public static PloResponseDTO EntityToPloDTO(ProgramLearningOutcomes plo)
        {
            PloResponseDTO dto = new PloResponseDTO();
            dto.Id = plo.Id;
            dto.PLOName = plo.PLOName;
            dto.Description = plo.Description;
            dto.Code = plo.Code;
            dto.DegreeProgramId = plo.DegreeProgramId;

            dto.IsActive = plo.IsActive;
            dto.GlobalId = plo.GlobalId;
            dto.CreatedAt = plo.CreatedAt;
            dto.UpdatedAt = plo.UpdatedAt;
            dto.DeletedAt = plo.DeletedAt;
            dto.CreatedBy = plo.CreatedBy;
            dto.UpdatedBy = plo.UpdatedBy;
            dto.DeletedBy = plo.DeletedBy;

            return dto;
        }

        // List of PloResponseDTO Mapper
        public static List<PloResponseDTO> EntitiesToPloDTOs(List<ProgramLearningOutcomes> plos)
        {
            List<PloResponseDTO> responseList = new List<PloResponseDTO>();
            foreach (ProgramLearningOutcomes plo in plos)
            {
                PloResponseDTO dto = EntityToPloDTO(plo);
                responseList.Add(dto);
            }
            return responseList;
        }
    }
}
