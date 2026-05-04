using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class SemesterDTOMappers
    {
        // Create DTO Mapper
        public static Semester SemesterDTOToEntityMappers(SemesterRequestDTO semesterRequestDTO)
        {
            Semester semester = new Semester();
            semester.SemesterName = semesterRequestDTO.SemesterName;
            semester.Code = semesterRequestDTO.Code;
            semester.Description = semesterRequestDTO.Description;
            return semester;
        }
        // Edit DTO Mapper
        public static Semester SemesterDTOToEditEntityMappers(Semester semester, SemesterRequestDTO semesterRequestDTO)
        {
            semester.SemesterName = semesterRequestDTO.SemesterName;
            semester.Code = semesterRequestDTO.Code;
            semester.Description = semesterRequestDTO.Description;
            semester.UpdatedAt = DateTime.Now;
            return semester;
        }

        // Response DTO Mapper
        public static SemesterResponseDTO EntityToSemesterDTO(Semester semester)
        {
            SemesterResponseDTO semesterResponseDTO = new SemesterResponseDTO();
            semesterResponseDTO.Id = semester.Id;
            semesterResponseDTO.SemesterName = semester.SemesterName;
            semesterResponseDTO.Code = semester.Code;
            semesterResponseDTO.Description = semester.Description;
            semesterResponseDTO.CreatedAt = DateTime.Now;
            semesterResponseDTO.UpdatedAt = DateTime.Now;
            semesterResponseDTO.GlobalId = semester.GlobalId;
            return semesterResponseDTO;
        }

        // List of SemesterResponseDTO Mapper
        public static List<SemesterResponseDTO> EntitiesToSemesterDTOs(List<Semester> semesters)
        {
            List<SemesterResponseDTO> semesterResponseDTOs = new List<SemesterResponseDTO>();
            foreach (Semester semester in semesters)
            {
                SemesterResponseDTO semesterResponseDTO = EntityToSemesterDTO(semester);
                semesterResponseDTOs.Add(semesterResponseDTO);
            }
            return semesterResponseDTOs;
        }
    }
}
