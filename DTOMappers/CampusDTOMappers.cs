using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class CampusDTOMappers
    {
        // Create Campus DTO Mapper
        public static Campus CampusDTOToEntityMapper(CampusRequestDTO campusDTO)
        {
            Campus campus = new Campus();
            campus.CampusName = campusDTO.CampusName;
            campus.Code = campusDTO.Code;
            campus.Description = campusDTO.Description;
            campus.EstablishedIn = campusDTO.EstablishedIn;
            campus.Address = campusDTO.Address;
            campus.UniversityId = campusDTO.UniversityId;
            campus.IsActive = true;
            return campus;
        }

        // Edit Campus DTO Mapper
        public static Campus CampusDTOToEditEntityMapper(Campus campus, CampusRequestDTO campusDTO)
        {
            campus.CampusName = campusDTO.CampusName;
            campus.Code = campusDTO.Code;
            campus.Description = campusDTO.Description;
            campus.EstablishedIn = campusDTO.EstablishedIn;
            campus.Address = campusDTO.Address;
            campus.UniversityId = campusDTO.UniversityId;
            campus.UpdatedAt = DateTime.Now;
            return campus;
        }

        // Entity to Response DTO
        public static CampusResponseDTO EntityToCampusDTO(Campus campus)
        {
            CampusResponseDTO campusResponseDTO = new CampusResponseDTO();
            campusResponseDTO.Id = campus.Id;
            campusResponseDTO.CampusName = campus.CampusName;
            campusResponseDTO.Code = campus.Code;
            campusResponseDTO.Description = campus.Description;
            campusResponseDTO.EstablishedIn = campus.EstablishedIn;
            campusResponseDTO.Address = campus.Address;
            campusResponseDTO.UniversityId = campus.UniversityId;

            campusResponseDTO.IsActive = campus.IsActive;
            campusResponseDTO.GlobalId = campus.GlobalId;
            campusResponseDTO.CreatedAt = campus.CreatedAt;
            campusResponseDTO.UpdatedAt = campus.UpdatedAt;
            campusResponseDTO.DeletedAt = campus.DeletedAt;
            campusResponseDTO.CreatedBy = campus.CreatedBy;
            campusResponseDTO.UpdatedBy = campus.UpdatedBy;
            campusResponseDTO.DeletedBy = campus.DeletedBy;

            return campusResponseDTO;
        }

        // List of CampusResponseDTO Mapper
        public static List<CampusResponseDTO> EntitiesToCampusDTOs(List<Campus> campuses)
        {
            List<CampusResponseDTO> campusResponseDTOs = new List<CampusResponseDTO>();
            foreach (Campus campus in campuses)
            {
                CampusResponseDTO campusResponseDTO = EntityToCampusDTO(campus);
                campusResponseDTOs.Add(campusResponseDTO);
            }
            return campusResponseDTOs;
        }
    }
}
