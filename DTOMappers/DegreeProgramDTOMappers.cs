using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class DegreeProgramDTOMappers
    {
        // Create DegreeProgram DTO Mapper
        public static DegreeProgram DegreeProgramDTOToEntityMapper(DegreeProgramRequestDTO dto)
        {
            DegreeProgram degreeProgram = new DegreeProgram();
            degreeProgram.DegreeProgramName = dto.LevelName;
            degreeProgram.Description = dto.Description;
            degreeProgram.Code = dto.Code;
            degreeProgram.DegreeLevelId = dto.DegreeLevelId;
            degreeProgram.DepartmentId = dto.DepartmentId;
            degreeProgram.IsActive = true;
            return degreeProgram;
        }

        // Edit DegreeProgram DTO Mapper
        public static DegreeProgram DegreeProgramDTOToEditEntityMapper(DegreeProgram degreeProgram, DegreeProgramRequestDTO dto)
        {
            degreeProgram.DegreeProgramName = dto.LevelName;
            degreeProgram.Description = dto.Description;
            degreeProgram.Code = dto.Code;
            degreeProgram.DegreeLevelId = dto.DegreeLevelId;
            degreeProgram.DepartmentId = dto.DepartmentId;
            degreeProgram.UpdatedAt = DateTime.Now;
            return degreeProgram;
        }

        // Entity to Response DTO
        public static DegreeProgramResponseDTO EntityToDegreeProgramDTO(DegreeProgram degreeProgram)
        {
            DegreeProgramResponseDTO dto = new DegreeProgramResponseDTO();
            dto.Id = degreeProgram.Id;
            dto.LevelName = degreeProgram.DegreeProgramName;
            dto.Description = degreeProgram.Description;
            dto.Code = degreeProgram.Code;
            dto.DegreeLevelId = degreeProgram.DegreeLevelId;
            dto.DepartmentId = degreeProgram.DepartmentId;

            dto.IsActive = degreeProgram.IsActive;
            dto.GlobalId = degreeProgram.GlobalId;
            dto.CreatedAt = degreeProgram.CreatedAt;
            dto.UpdatedAt = degreeProgram.UpdatedAt;
            dto.DeletedAt = degreeProgram.DeletedAt;
            dto.CreatedBy = degreeProgram.CreatedBy;
            dto.UpdatedBy = degreeProgram.UpdatedBy;
            dto.DeletedBy = degreeProgram.DeletedBy;

            return dto;
        }

        // List of DegreeProgramResponseDTO Mapper
        public static List<DegreeProgramResponseDTO> EntitiesToDegreeProgramDTOs(List<DegreeProgram> degreePrograms)
        {
            List<DegreeProgramResponseDTO> responseList = new List<DegreeProgramResponseDTO>();
            foreach (DegreeProgram degreeProgram in degreePrograms)
            {
                DegreeProgramResponseDTO dto = EntityToDegreeProgramDTO(degreeProgram);
                responseList.Add(dto);
            }
            return responseList;
        }
    }
}
