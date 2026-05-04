using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class RoomFeatureAllocationDTOMappers
    {
        // Create RoomFeatureAllocation DTO Mapper
        public static RoomFeatureAllocation RoomFeatureAllocationDTOToEntityMapper(RoomFeatureAllocationRequestDTO dto)
        {
            RoomFeatureAllocation entity = new RoomFeatureAllocation();
            entity.RoomFeatureId = dto.RoomFeatureId;
            entity.RoomId = dto.RoomId;
            entity.Quantity = dto.Quantity;
            entity.IsActive = true;
            return entity;
        }

        // Edit RoomFeatureAllocation DTO Mapper
        public static RoomFeatureAllocation RoomFeatureAllocationDTOToEditEntityMapper(RoomFeatureAllocation entity, RoomFeatureAllocationRequestDTO dto)
        {
            entity.RoomFeatureId = dto.RoomFeatureId;
            entity.RoomId = dto.RoomId;
            entity.Quantity = dto.Quantity;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        // Entity to Response DTO
        public static RoomFeatureAllocationResponseDTO EntityToRoomFeatureAllocationDTO(RoomFeatureAllocation entity)
        {
            RoomFeatureAllocationResponseDTO dto = new RoomFeatureAllocationResponseDTO();
            dto.Id = entity.Id;
            dto.RoomFeatureId = entity.RoomFeatureId;
            dto.RoomId = entity.RoomId;
            dto.Quantity = entity.Quantity;

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

        // List of RoomFeatureAllocationResponseDTO Mapper
        public static List<RoomFeatureAllocationResponseDTO> EntitiesToRoomFeatureAllocationDTOs(List<RoomFeatureAllocation> entities)
        {
            List<RoomFeatureAllocationResponseDTO> responseList = new List<RoomFeatureAllocationResponseDTO>();
            foreach (RoomFeatureAllocation entity in entities)
            {
                RoomFeatureAllocationResponseDTO dto = EntityToRoomFeatureAllocationDTO(entity);
                responseList.Add(dto);
            }
            return responseList;
        }
    }
}
