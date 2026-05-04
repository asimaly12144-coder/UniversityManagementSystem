using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class FacultyCampusDTOMappers
    {
        // Create FacultyCampus DTO Mapper
        public static FacultyCampus FacultyCampusDTOToEntityMapper(FacultyCampusRequestDTO dto)
        {
            FacultyCampus facultyCampus = new FacultyCampus();
            facultyCampus.FacultyId = dto.FacultyId;
            facultyCampus.CampusId = dto.CampusId;
            facultyCampus.IsActive = true;
            return facultyCampus;
        }

        // Edit FacultyCampus DTO Mapper
        public static FacultyCampus FacultyCampusDTOToEditEntityMapper(FacultyCampus facultyCampus, FacultyCampusRequestDTO dto)
        {
            facultyCampus.FacultyId = dto.FacultyId;
            facultyCampus.CampusId = dto.CampusId;
            facultyCampus.UpdatedAt = DateTime.Now;
            return facultyCampus;
        }

        // Entity to Response DTO
        public static FacultyCampusResponseDTO EntityToFacultyCampusDTO(FacultyCampus facultyCampus)
        {
            FacultyCampusResponseDTO dto = new FacultyCampusResponseDTO();
            dto.Id = facultyCampus.Id;
            dto.FacultyId = facultyCampus.FacultyId;
            dto.CampusId = facultyCampus.CampusId;

            dto.IsActive = facultyCampus.IsActive;
            dto.GlobalId = facultyCampus.GlobalId;
            dto.CreatedAt = facultyCampus.CreatedAt;
            dto.UpdatedAt = facultyCampus.UpdatedAt;
            dto.DeletedAt = facultyCampus.DeletedAt;
            dto.CreatedBy = facultyCampus.CreatedBy;
            dto.UpdatedBy = facultyCampus.UpdatedBy;
            dto.DeletedBy = facultyCampus.DeletedBy;

            return dto;
        }

        // List of FacultyCampusResponseDTO Mapper
        public static List<FacultyCampusResponseDTO> EntitiesToFacultyCampusDTOs(List<FacultyCampus> facultyCampuses)
        {
            List<FacultyCampusResponseDTO> responseList = new List<FacultyCampusResponseDTO>();
            foreach (FacultyCampus facultyCampus in facultyCampuses)
            {
                FacultyCampusResponseDTO dto = EntityToFacultyCampusDTO(facultyCampus);
                responseList.Add(dto);
            }
            return responseList;
        }
    }
}
