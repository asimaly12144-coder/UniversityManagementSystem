using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class PloToCloDTOMappers
    {
        // Create PloToClo DTO Mapper
        public static PloToClo PloToCloDTOToEntityMapper(PloToCloRequestDTO dto)
        {
            PloToClo entity = new PloToClo();
            entity.PloId = dto.PloId;
            entity.CloId = dto.CloId;
            entity.Weightage = dto.Weightage;
            entity.IsActive = true;
            return entity;
        }

        // Edit PloToClo DTO Mapper
        public static PloToClo PloToCloDTOToEditEntityMapper(PloToClo entity, PloToCloRequestDTO dto)
        {
            entity.PloId = dto.PloId;
            entity.CloId = dto.CloId;
            entity.Weightage = dto.Weightage;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        // Entity to Response DTO
        public static PloToCloResponse EntityToPloToCloDTO(PloToClo entity)
        {
            PloToCloResponse dto = new PloToCloResponse();
            dto.Id = entity.Id;
            dto.PloId = entity.PloId;
            dto.CloId = entity.CloId;
            dto.Weightage = entity.Weightage;

            dto.IsActive = entity.IsActive;
            dto.GlobalId = entity.GlobalId;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.DeletedAt = entity.DeletedAt;
            dto.CreatedBy = entity.CreatedBy;
            dto.UpdatedBy = entity.UpdatedBy;
            dto.DeletedBy = entity.DeletedBy;

            return dto;
        }

        // List of PloToCloResponseDTO Mapper
        public static List<PloToCloResponse> EntitiesToPloToCloDTOs(List<PloToClo> entities)
        {
            List<PloToCloResponse> responseList = new List<PloToCloResponse>();
            foreach (PloToClo entity in entities)
            {
                PloToCloResponse dto = EntityToPloToCloDTO(entity);
                responseList.Add(dto);
            }
            return responseList;
        }
    }
}
