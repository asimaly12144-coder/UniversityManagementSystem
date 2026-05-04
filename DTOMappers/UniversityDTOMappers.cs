using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class UniversityDTOMapper
    {
        //Create University DTO Mapper
        public static University UniversityDTOToEntityMapper(UniversityRequestDTO universityDTO)
        {
            University university = new University();
            university.UniversityName = universityDTO.UniversityName;
            university.Description = universityDTO.Description;
            university.EstablishedIn = universityDTO.EstablishedIn;
            university.Address = universityDTO.Address;
            university.IsActive = true;
            return university;
        }
        //
       

        // University Edit DTO Mapper

        public static University UniversityDTOToEditEntityMapper(University university, UniversityRequestDTO universityDTO)
        {
            university.UniversityName = universityDTO.UniversityName;
            university.Description = universityDTO.Description;
            university.EstablishedIn = universityDTO.EstablishedIn;
            university.Address = universityDTO.Address;
            university.UpdatedAt = DateTime.Now;
            return university;
        }
        // University Response DTO Mapper
        public static UniversityResponseDTO EntityToUniversityDTO(University university)
        {
            UniversityResponseDTO universityResponseDTO = new UniversityResponseDTO();
            universityResponseDTO.Id = university.Id;
            universityResponseDTO.UniversityName = university.UniversityName;
            universityResponseDTO.Description = university.Description;
            universityResponseDTO.EstablishedIn = university.EstablishedIn;
            universityResponseDTO.Address = university.Address;
            universityResponseDTO.IsActive = university.IsActive;
            universityResponseDTO.CreatedAt = DateTime.Now;
            universityResponseDTO.UpdatedAt = DateTime.Now;
            universityResponseDTO.GlobalId = university.GlobalId;
            return universityResponseDTO;
        }
        //Subject Response DTO Mapper
        // List of UniversityResponseDTO Mapper
        public static List<UniversityResponseDTO> EntitiesToUniversityDTOs(List<University> universitys)
        {
            List<UniversityResponseDTO> universityResponseDTOs = new List<UniversityResponseDTO>();
            foreach (University university in universitys)
            {
                UniversityResponseDTO universityResponseDTO = EntityToUniversityDTO(university);
                universityResponseDTOs.Add(universityResponseDTO);
            }
            return universityResponseDTOs;
        }
        
       
    }
}
