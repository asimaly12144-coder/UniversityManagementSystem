using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class CourseSchemeDTOMappers
    {
        // Create CourseScheme DTO Mapper
        public static CourseScheme CourseSchemeDTOToEntityMapper(CourseSchemeRequestDTO dto)
        {
            CourseScheme courseScheme = new CourseScheme();
            courseScheme.ProgramSessionId = dto.ProgramSessionId;
            courseScheme.DegreeProgramId = dto.DegreeProgramId;
            courseScheme.SubjectTypeId = dto.SubjectTypeId;
            courseScheme.SubjectId = dto.SubjectId;
            courseScheme.SemesterId = dto.SemesterId;
            courseScheme.IsActive = true;
            return courseScheme;
        }

        // Edit CourseScheme DTO Mapper
        public static CourseScheme CourseSchemeDTOToEditEntityMapper(CourseScheme courseScheme, CourseSchemeRequestDTO dto)
        {
            courseScheme.ProgramSessionId = dto.ProgramSessionId;
            courseScheme.DegreeProgramId = dto.DegreeProgramId;
            courseScheme.SubjectTypeId = dto.SubjectTypeId;
            courseScheme.SubjectId = dto.SubjectId;
            courseScheme.SemesterId = dto.SemesterId;
            courseScheme.UpdatedAt = DateTime.Now;
            return courseScheme;
        }

        // Entity to Response DTO
        public static CourseSchemeResponseDTO EntityToCourseSchemeDTO(CourseScheme courseScheme)
        {
            CourseSchemeResponseDTO dto = new CourseSchemeResponseDTO();
            dto.Id = courseScheme.Id;
            dto.ProgramSessionId = courseScheme.ProgramSessionId;
            dto.DegreeProgramId = courseScheme.DegreeProgramId;
            dto.SubjectTypeId = courseScheme.SubjectTypeId;
            dto.SubjectId = courseScheme.SubjectId;
            dto.SemesterId = courseScheme.SemesterId;

            dto.IsActive = courseScheme.IsActive;
            dto.GlobalId = courseScheme.GlobalId;
            dto.CreatedAt = courseScheme.CreatedAt;
            dto.UpdatedAt = courseScheme.UpdatedAt;
            dto.DeletedAt = courseScheme.DeletedAt;
            dto.CreatedBy = courseScheme.CreatedBy;
            dto.UpdatedBy = courseScheme.UpdatedBy;
            dto.DeletedBy = courseScheme.DeletedBy;

            return dto;
        }

        // List of CourseSchemeResponseDTO Mapper
        public static List<CourseSchemeResponseDTO> EntitiesToCourseSchemeDTOs(List<CourseScheme> courseSchemes)
        {
            List<CourseSchemeResponseDTO> responseList = new List<CourseSchemeResponseDTO>();
            foreach (CourseScheme courseScheme in courseSchemes)
            {
                CourseSchemeResponseDTO dto = EntityToCourseSchemeDTO(courseScheme);
                responseList.Add(dto);
            }
            return responseList;
        }
    }
}
