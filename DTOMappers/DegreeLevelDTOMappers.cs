using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class DegreeLevelDTOMappers
    {
        public static DegreeLevel DegreeLevelDTOToEntityMapper(DegreeLevelRequestDTO degreeLevelRequestDTO)
        {
            DegreeLevel degreeLevel = new DegreeLevel();
            degreeLevel.DegreeLevelName = degreeLevelRequestDTO.DegreeLevelName;
            degreeLevel.Description = degreeLevelRequestDTO.Description;
            degreeLevel.Code = degreeLevelRequestDTO.Code;
            degreeLevel.IsActive = true;
            return degreeLevel; 
        }

        // DegreeLevel Response 
        public static DegreeLevelResponseDTO EntityToDegreeLevel(DegreeLevel degreeLevel)
        {
            DegreeLevelResponseDTO degreeLevelResponse = new DegreeLevelResponseDTO();
            degreeLevelResponse.Id = degreeLevel.Id;
            degreeLevelResponse.DegreeLevelName = degreeLevel.DegreeLevelName;
            degreeLevelResponse.Description = degreeLevel.Description;
            degreeLevelResponse.Code = degreeLevel.Code;
            degreeLevelResponse.IsActive = degreeLevel.IsActive;
            degreeLevelResponse.CreatedAt = DateTime.Now;
            degreeLevelResponse.UpdatedAt = DateTime.Now;
            degreeLevelResponse.GlobalId = degreeLevel.GlobalId;
            return degreeLevelResponse;
        }

        // DegreeLevel Edit DTO Mapper

        public static DegreeLevel DegreeLevelDTOToEditEntityMapper(DegreeLevel degreeLevel, DegreeLevelRequestDTO degreeLevelRequestDTO)
        {
            degreeLevel.DegreeLevelName = degreeLevelRequestDTO.DegreeLevelName;
            degreeLevel.Description = degreeLevelRequestDTO.Description;
            degreeLevel.Code = degreeLevelRequestDTO.Code;
            degreeLevel.UpdatedAt = DateTime.Now;
            return degreeLevel;
        }

        // List of DegreeLevelResponse Mapper

        public static List<DegreeLevelResponseDTO> EntitiesToDegreeLevelDTOs(List<DegreeLevel> degreeLevels)
        {
            List<DegreeLevelResponseDTO> degreeLevelResponses = new List<DegreeLevelResponseDTO>();
            foreach (DegreeLevel degreeLevel in degreeLevels)
            {
                DegreeLevelResponseDTO degreeLevelResponse = EntityToDegreeLevel(degreeLevel);
                degreeLevelResponses.Add(degreeLevelResponse);

            }
            return degreeLevelResponses;
        }
    }
}
