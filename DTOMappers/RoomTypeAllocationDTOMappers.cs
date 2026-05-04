using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class RoomTypeAllocationDTOMappers
    {
        // Create Mapper
        public static RoomTypeAllocation RoomTypeAllocationDTOToEntityMapper(RoomTypeAllocationRequest dto)
        {
            RoomTypeAllocation entity = new RoomTypeAllocation();
            entity.RoomTypeId = dto.RoomTypeId;
            entity.RoomId = dto.RoomId;
            entity.IsActive = true;
            return entity;
        }

        // Edit Mapper
        public static RoomTypeAllocation RoomTypeAllocationDTOToEditEntityMapper(RoomTypeAllocation entity, RoomTypeAllocationRequest dto)
        {
            entity.RoomTypeId = dto.RoomTypeId;
            entity.RoomId = dto.RoomId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        // Entity to DTO
        public static RoomTypeAllocationResponseDTO EntityToRoomTypeAllocationDTO(RoomTypeAllocation entity)
        {
            RoomTypeAllocationResponseDTO dto = new RoomTypeAllocationResponseDTO();
            dto.Id = entity.Id;
            dto.RoomTypeId = entity.RoomTypeId;
            dto.RoomId = entity.RoomId;

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
        public static List<RoomTypeAllocationResponseDTO> EntitiesToRoomTypeAllocationDTOs(List<RoomTypeAllocation> entities)
        {
            List<RoomTypeAllocationResponseDTO> list = new List<RoomTypeAllocationResponseDTO>();
            foreach (var entity in entities)
            {
                list.Add(EntityToRoomTypeAllocationDTO(entity));
            }
            return list;
        }
    }
}
