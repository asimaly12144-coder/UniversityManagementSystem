using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class CLODTOMappers
    {
        // Create CLO DTO Mapper
        public static CourseLearningOutcomes CloDTOToEntityMapper(CLORequesDTO cloDTO)
        {
            CourseLearningOutcomes clo = new CourseLearningOutcomes();
            clo.Description = cloDTO.Description;
            clo.Code = cloDTO.Code;
            clo.SubjectTypeId = cloDTO.SubjectTypeId;
            clo.LearningLevelId = cloDTO.LearningLevelId;
            clo.IsActive = true;
            return clo;
        }

        // Edit CLO DTO Mapper
        public static CourseLearningOutcomes CloDTOToEditEntityMapper(CourseLearningOutcomes clo, CLORequesDTO cloDTO)
        {
            clo.Description = cloDTO.Description;
            clo.Code = cloDTO.Code;
            clo.SubjectTypeId = cloDTO.SubjectTypeId;
            clo.LearningLevelId = cloDTO.LearningLevelId;
            clo.UpdatedAt = DateTime.Now;
            return clo;
        }

        // Entity to Response DTO
        public static CloResponseDTO EntityToCloDTO(CourseLearningOutcomes clo)
        {
            CloResponseDTO cloResponseDTO = new CloResponseDTO();
            cloResponseDTO.Id = clo.Id;
            cloResponseDTO.Description = clo.Description;
            cloResponseDTO.Code = clo.Code;
            cloResponseDTO.SubjectTypeId = clo.SubjectTypeId;
            cloResponseDTO.LearningLevelId = clo.LearningLevelId;

            cloResponseDTO.IsActive = clo.IsActive;
            cloResponseDTO.GlobalId = clo.GlobalId;
            cloResponseDTO.CreatedAt = clo.CreatedAt;
            cloResponseDTO.UpdatedAt = clo.UpdatedAt;
            cloResponseDTO.DeletedAt = clo.DeletedAt;
            cloResponseDTO.CreatedBy = clo.CreatedBy;
            cloResponseDTO.UpdatedBy = clo.UpdatedBy;
            cloResponseDTO.DeletedBy = clo.DeletedBy;

            return cloResponseDTO;
        }

        // List of CloResponseDTO Mapper
        public static List<CloResponseDTO> EntitiesToCloDTOs(List<CourseLearningOutcomes> clos)
        {
            List<CloResponseDTO> cloResponseDTOs = new List<CloResponseDTO>();
            foreach (CourseLearningOutcomes clo in clos)
            {
                CloResponseDTO cloResponseDTO = EntityToCloDTO(clo);
                cloResponseDTOs.Add(cloResponseDTO);
            }
            return cloResponseDTOs;
        }
    }
}
