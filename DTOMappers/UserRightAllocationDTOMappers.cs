using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class UserRightAllocationDTOMappers
    {
        // Create Mapper
        public static UserRightAllocation DTOToEntity(UserRightAllocationRequestDTO dto)
        {
            UserRightAllocation entity = new UserRightAllocation();
            entity.UserRightId = dto.UserRightId;
            entity.UserTypeId = dto.UserTypeId;
            entity.IsActive = true;
            return entity;
        }

        // Edit Mapper
        public static UserRightAllocation DTOToEditEntity(UserRightAllocation entity, UserRightAllocationRequestDTO dto)
        {
            entity.UserRightId = dto.UserRightId;
            entity.UserTypeId = dto.UserTypeId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        // Single Response Mapper
        public static UseRightAllocationResponseDTO EntityToDTO(UserRightAllocation entity)
        {
            UseRightAllocationResponseDTO dto = new UseRightAllocationResponseDTO();
            dto.Id = entity.Id;
            dto.UserRightId = entity.UserRightId;
            dto.UserTypeId = entity.UserTypeId;
            dto.IsActive = entity.IsActive;
            dto.GlobalId = entity.GlobalId;
            dto.CreatedAt = DateTime.Now;
            dto.UpdatedAt = DateTime.Now;        
            return dto;
        }

        // List Mapper
        public static List<UseRightAllocationResponseDTO> EntitiesToDTOs(List<UserRightAllocation> entities)
        {
            List<UseRightAllocationResponseDTO> dtos = new List<UseRightAllocationResponseDTO>();
            foreach (var entity in entities)
            {
                dtos.Add(EntityToDTO(entity));
            }
            return dtos;
        }
    }
}
