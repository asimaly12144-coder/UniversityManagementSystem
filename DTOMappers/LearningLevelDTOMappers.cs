using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class LearningLevelDTOMappers
    {
        // Create LearningLevel DTO Mapper
        public static LearningLevel LearningLevelDTOToEntityMapper(LearningLevelRequestDTO dto)
        {
            LearningLevel learningLevel = new LearningLevel();
            learningLevel.LearningLevelName = dto.LearningLevelName;
            learningLevel.Description = dto.Description;
            learningLevel.Code = dto.Code;
            learningLevel.IsActive = true;
            return learningLevel;
        }

        // Edit LearningLevel DTO Mapper
        public static LearningLevel LearningLevelDTOToEditEntityMapper(LearningLevel learningLevel, LearningLevelRequestDTO dto)
        {
            learningLevel.LearningLevelName = dto.LearningLevelName;
            learningLevel.Description = dto.Description;
            learningLevel.Code = dto.Code;
            learningLevel.UpdatedAt = DateTime.Now;
            return learningLevel;
        }

        // Entity to Response DTO
        public static LearningLevelResponseDTO EntityToLearningLevelDTO(LearningLevel learningLevel)
        {
            LearningLevelResponseDTO dto = new LearningLevelResponseDTO();
            dto.Id = learningLevel.Id;
            dto.LearningLevelName = learningLevel.LearningLevelName;
            dto.Description = learningLevel.Description;
            dto.Code = learningLevel.Code;

            dto.IsActive = learningLevel.IsActive;
            dto.GlobalId = learningLevel.GlobalId;
            dto.CreatedAt = learningLevel.CreatedAt;
            dto.UpdatedAt = learningLevel.UpdatedAt;
            dto.DeletedAt = learningLevel.DeletedAt;
            dto.CreatedBy = learningLevel.CreatedBy;
            dto.UpdatedBy = learningLevel.UpdatedBy;
            dto.DeletedBy = learningLevel.DeletedBy;

            return dto;
        }

        // List of LearningLevelResponseDTO Mapper
        public static List<LearningLevelResponseDTO> EntitiesToLearningLevelDTOs(List<LearningLevel> learningLevels)
        {
            List<LearningLevelResponseDTO> responseList = new List<LearningLevelResponseDTO>();
            foreach (LearningLevel learningLevel in learningLevels)
            {
                LearningLevelResponseDTO dto = EntityToLearningLevelDTO(learningLevel);
                responseList.Add(dto);
            }
            return responseList;
        }
    }
}
