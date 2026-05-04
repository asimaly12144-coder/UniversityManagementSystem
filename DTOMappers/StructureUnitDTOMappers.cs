using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class StructureUnitDTOMappers
    {
        // Create Mapper
        public static StructureUnit StructureUnitDTOToEntityMapper(StructureUnitRequestDTO dto)
        {
            StructureUnit entity = new StructureUnit();
            entity.StructureUnitName = dto.StructureUnitName;
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            entity.StructureTypeId = dto.StructureTypeId;
            entity.IsActive = true;
            return entity;
        }

        // Edit Mapper
        public static StructureUnit StructureUnitDTOToEditEntityMapper(StructureUnit entity, StructureUnitRequestDTO dto)
        {
            entity.StructureUnitName = dto.StructureUnitName;
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            entity.StructureTypeId = dto.StructureTypeId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        // Entity to DTO
        public static StructureUnitResponseDTO EntityToStructureUnitDTO(StructureUnit entity)
        {
            StructureUnitResponseDTO dto = new StructureUnitResponseDTO();
            dto.Id = entity.Id;
            dto.StructureUnitName = entity.StructureUnitName;
            dto.Description = entity.Description;
            dto.Code = entity.Code;
            dto.StructureTypeId = entity.StructureTypeId;

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
        public static List<StructureUnitResponseDTO> EntitiesToStructureUnitDTOs(List<StructureUnit> entities)
        {
            List<StructureUnitResponseDTO> responseList = new List<StructureUnitResponseDTO>();
            foreach (var entity in entities)
            {
                responseList.Add(EntityToStructureUnitDTO(entity));
            }
            return responseList;
        }
    }
}
