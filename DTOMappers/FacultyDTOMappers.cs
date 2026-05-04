using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class FacultyDTOMappers
    {
        // Create Faculty Entity from FacultyRequestDTO
        public static Faculty FacultyDTOToEntityMappers(FacultyRequestDTO facultyRequestDTO)
        {
            Faculty faculty = new Faculty();
            faculty.FacultyName = facultyRequestDTO.FacultyName;
            faculty.Description = facultyRequestDTO.Description;
            faculty.Code = facultyRequestDTO.Code;
            faculty.EstablishedIn = facultyRequestDTO.EstablishedIn;
            faculty.IsActive = true;
            return faculty;
        }
        // Edit Faculty Entity from FacultyRequestDTO
        public static Faculty FacultyDTOToEditEntityMappers(Faculty faculty, FacultyRequestDTO facultyRequestDTO)
        {
            faculty.FacultyName = facultyRequestDTO.FacultyName;
            faculty.Description = facultyRequestDTO.Description;
            faculty.Code = facultyRequestDTO.Code;
            faculty.EstablishedIn = facultyRequestDTO.EstablishedIn;
            faculty.UpdatedAt = DateTime.Now;
            return faculty;
        }

        // Response DTO Mapper

        public static FacultyResponseDTO EntityToFacultyDTO(Faculty faculty)
        {
            FacultyResponseDTO facultyResponseDTO = new FacultyResponseDTO();
            facultyResponseDTO.Id = faculty.Id;
            facultyResponseDTO.FacultyName = faculty.FacultyName;
            facultyResponseDTO.Description = faculty.Description;
            facultyResponseDTO.Code = faculty.Code;
            facultyResponseDTO.CreatedAt = DateTime.Now;
            facultyResponseDTO.UpdatedAt = DateTime.Now;
            facultyResponseDTO.GlobalId = faculty.GlobalId;
            return facultyResponseDTO;
        }

        // Convert List of Faculty Entities to List of FacultyResponseDTOs
        public static List<FacultyResponseDTO> EntityToFacultyDTOs(List<Faculty> faculties)
        {
            List<FacultyResponseDTO> facultyResponseDTOs = new List<FacultyResponseDTO>();
            foreach (Faculty faculty in faculties)
            {
                FacultyResponseDTO facultyResponseDTO = EntityToFacultyDTO(faculty);
                facultyResponseDTOs.Add(facultyResponseDTO);
            }
            return facultyResponseDTOs;
        }
    }
}
