using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class SubjectDTOMappers
    {
        public static Subject SubjectDTOToEntityMappers(SubjectRequestDTO subjectRequestDTO)
        {
            Subject subject = new Subject();
            subject.Description = subjectRequestDTO.Description;
            subject.SubjectName = subjectRequestDTO.SubjectName;
            subject.Code = subjectRequestDTO.Code;
            return subject;
        }

        // Edit

        public static Subject SubjectDTOToEditEntityMappers(Subject subject, SubjectRequestDTO subjectRequestDTO)
        {
            subject.Description = subjectRequestDTO.Description;
            subject.SubjectName = subjectRequestDTO.SubjectName;
            subject.Code = subjectRequestDTO.Code;
            subject.UpdatedAt = DateTime.Now;
            return subject;
        }
        // Response DTO Mapper
        public static SubjectResponseDTO EntityToSubjectDTO(Subject subject)
        {
            SubjectResponseDTO subjectResponseDTO = new SubjectResponseDTO();
            subjectResponseDTO.Id = subject.Id;
            subjectResponseDTO.SubjectName = subject.SubjectName;
            subjectResponseDTO.Code = subject.Code;
            subjectResponseDTO.Description = subject.Description;
            subjectResponseDTO.CreatedAt = DateTime.Now;
            subjectResponseDTO.UpdatedAt = DateTime.Now;
            subjectResponseDTO.GlobalId = subject.GlobalId;
            return subjectResponseDTO;
        }

        // List 

        public static List<SubjectResponseDTO> EntityToSubjectDTOs(List<Subject> subjects)
        {
            List<SubjectResponseDTO> subjectResponseDTOs = new List<SubjectResponseDTO>();
            foreach (Subject subject in subjects)
            {
                SubjectResponseDTO subjectResponseDTO = EntityToSubjectDTO(subject);
                subjectResponseDTOs.Add(subjectResponseDTO);
            }
            return subjectResponseDTOs;
        }
    }
}
