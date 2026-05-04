using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class CloToSubjectDTOMappers
    {
        // Create CloToSubject DTO Mapper
        public static CloToSubject CloToSubjectDTOToEntityMapper(CloToSubjectRequestDTO dto)
        {
            CloToSubject cloToSubject = new CloToSubject();
            cloToSubject.CloId = dto.CloId;
            cloToSubject.SubjectId = dto.SubjectId;
            cloToSubject.ProgramSessionId = dto.ProgramSessionId;
            cloToSubject.IsActive = true;
            return cloToSubject;
        }

        // Edit CloToSubject DTO Mapper
        public static CloToSubject CloToSubjectDTOToEditEntityMapper(CloToSubject cloToSubject, CloToSubjectRequestDTO dto)
        {
            cloToSubject.CloId = dto.CloId;
            cloToSubject.SubjectId = dto.SubjectId;
            cloToSubject.ProgramSessionId = dto.ProgramSessionId;
            cloToSubject.UpdatedAt = DateTime.Now;
            return cloToSubject;
        }

        // Entity to Response DTO
        public static CloToSubjectResponseDTO EntityToCloToSubjectDTO(CloToSubject cloToSubject)
        {
            CloToSubjectResponseDTO dto = new CloToSubjectResponseDTO();
            dto.Id = cloToSubject.Id;
            dto.CloId = cloToSubject.CloId;
            dto.SubjectId = cloToSubject.SubjectId;
            dto.ProgramSessionId = cloToSubject.ProgramSessionId;

            dto.IsActive = cloToSubject.IsActive;
            dto.GlobalId = cloToSubject.GlobalId;
            dto.CreatedAt = cloToSubject.CreatedAt;
            dto.UpdatedAt = cloToSubject.UpdatedAt;
            dto.DeletedAt = cloToSubject.DeletedAt;
            dto.CreatedBy = cloToSubject.CreatedBy;
            dto.UpdatedBy = cloToSubject.UpdatedBy;
            dto.DeletedBy = cloToSubject.DeletedBy;

            return dto;
        }
        // List of CloToSubjectResponseDTO Mapper
        public static List<CloToSubjectResponseDTO> EntitiesToCloToSubjectDTOs(List<CloToSubject> cloToSubjects)
        {
            List<CloToSubjectResponseDTO> responseList = new List<CloToSubjectResponseDTO>();
            foreach (CloToSubject cloToSubject in cloToSubjects)
            {
                CloToSubjectResponseDTO dto = EntityToCloToSubjectDTO(cloToSubject);
                responseList.Add(dto);
            }
            return responseList;
        }
    }
}
