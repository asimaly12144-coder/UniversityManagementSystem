using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class SubjectTypeDTOMappers
    {
        public static SubjectType SubjectTypeDTOToEntityMappers(SubjectTypeRequestDTO subjectTypeRequestDTO)
        {
            SubjectType subjectType = new SubjectType();
            subjectType.TypeName = subjectTypeRequestDTO.TypeName;
            subjectType.Description = subjectTypeRequestDTO.Description;
            subjectType.Code = subjectTypeRequestDTO.Code;
            return subjectType;
        }
        // Edit To DTO Mapper
        public static SubjectType SubjectTypeDTOToEditEntityMappers(SubjectType subjectType, SubjectTypeRequestDTO subjectTypeRequestDTO)
        {
            subjectType.TypeName = subjectTypeRequestDTO.TypeName;
            subjectType.Description = subjectTypeRequestDTO.Description;
            subjectType.Code = subjectTypeRequestDTO.Code;
            subjectType.UpdatedAt = DateTime.Now;
            return subjectType;
        }

        // Response DTO Mapper
        public static SubjectTypeResponseDTO EntityToSubjectTypeDTO(SubjectType subjectType)
        {
            SubjectTypeResponseDTO subjectTypeResponseDTO = new SubjectTypeResponseDTO();
            subjectTypeResponseDTO.Id = subjectType.Id;
            subjectTypeResponseDTO.TypeName = subjectType.TypeName;
            subjectTypeResponseDTO.Code = subjectType.Code;
            subjectTypeResponseDTO.Description = subjectType.Description;
            subjectTypeResponseDTO.CreatedAt = DateTime.Now;
            subjectTypeResponseDTO.UpdatedAt = DateTime.Now;
            subjectTypeResponseDTO.GlobalId = subjectType.GlobalId;
            return subjectTypeResponseDTO;
        }
        // List 
        public static List<SubjectTypeResponseDTO> EntitiesToSubjectTypeDTOs(List<SubjectType> subjectTypes)
        {
            List<SubjectTypeResponseDTO> subjectTypeList = new List<SubjectTypeResponseDTO>();
            foreach (SubjectType subjectType in subjectTypes)
            {
                SubjectTypeResponseDTO subjectTypeDTO = EntityToSubjectTypeDTO(subjectType);
                subjectTypeList.Add(subjectTypeDTO);
            }
            return subjectTypeList;
        }


    }
}
