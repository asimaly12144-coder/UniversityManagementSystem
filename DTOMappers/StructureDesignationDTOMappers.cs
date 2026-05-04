using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class StructureDesignationDTOMappers
    {
        // Create StructureDesignation DTO Mapper
        public static StructureDesignation StructureDesignationDTOToEntityMapper(StructureDesignationRequestDTO dto)
        {
            StructureDesignation entity = new StructureDesignation();
            entity.StructureUnitId = dto.StructureUnitId;
            entity.DesignationId = dto.DesignationId;
            entity.IsActive = true;
            return entity;
        }

        // Edit StructureDesignation DTO Mapper
        public static StructureDesignation StructureDesignationDTOToEditEntityMapper(StructureDesignation entity, StructureDesignationRequestDTO dto)
        {
            entity.StructureUnitId = dto.StructureUnitId;
            entity.DesignationId = dto.DesignationId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        // Entity to Response DTO
        public static StructureDesignationResponseDTO EntityToStructureDesignationDTO(StructureDesignation entity)
        {
            StructureDesignationResponseDTO dto = new StructureDesignationResponseDTO();
            dto.Id = entity.Id;
            dto.StructureUnitId = entity.StructureUnitId;
            dto.DesignationId = entity.DesignationId;

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

        // List Mapper
        public static List<StructureDesignationResponseDTO> EntitiesToStructureDesignationDTOs(List<StructureDesignation> entities)
        {
            List<StructureDesignationResponseDTO> list = new List<StructureDesignationResponseDTO>();
            foreach (var entity in entities)
            {
                list.Add(EntityToStructureDesignationDTO(entity));
            }
            return list;
        }
    }
}
