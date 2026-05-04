using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class UserTypeAllocationDTOMappers
    {
        // Create DTO Mapper
        public static UserTypeAllocation DTOToEntity(UserTypeAllocationRequestDTO dto)
        {
            UserTypeAllocation entity = new UserTypeAllocation();
            entity.UserTypeId = dto.UserTypeId;
            entity.UserInfoId = dto.UserInfoId;
            entity.IsActive = true;
            return entity;
        }

        // Edit DTO Mapper
        public static UserTypeAllocation DTOToEditEntity(UserTypeAllocation entity, UserTypeAllocationRequestDTO dto)
        {
            entity.UserTypeId = dto.UserTypeId;
            entity.UserInfoId = dto.UserInfoId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }
        
        public static UserTypeAllocationResponseDTO EntityToDTO(UserTypeAllocation entity)
        {
            UserTypeAllocationResponseDTO dto = new UserTypeAllocationResponseDTO();
            dto.Id = entity.Id;
            dto.UserTypeId = entity.UserTypeId;
            dto.UserInfoId = entity.UserInfoId;
            dto.IsActive = entity.IsActive;
            dto.GlobalId = entity.GlobalId;
            dto.CreatedAt = DateTime.Now;
            dto.UpdatedAt = DateTime.Now;
            return dto;
        }

        // List Mapper
        public static List<UserTypeAllocationResponseDTO> EntitiesToDTOs(List<UserTypeAllocation> entities)
        {
            List<UserTypeAllocationResponseDTO> list = new List<UserTypeAllocationResponseDTO>();
            foreach (var entity in entities)
            {
                list.Add(EntityToDTO(entity));
            }
            return list;
        }
    }
}
