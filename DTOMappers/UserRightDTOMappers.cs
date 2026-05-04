
    using UniversityManagmentSystem.DTOs.RequestDTO;
    using UniversityManagmentSystem.DTOs.ResponseDTO;
    using UniversityManagmentSystem.Models;

    namespace UniversityManagmentSystem.DTOMappers
    {
        public class UserRightDTOMappers
        {
            // Create UserRight DTO Mapper
            public static UserRight UserRightDTOToEntityMapper(UserRightRequestDTO dto)
            {
                UserRight entity = new UserRight();
                entity.UserRightCode = dto.UserRightCode;
                entity.UserRightName = dto.UserRightName;
                entity.URL = dto.URL;
                entity.TabName = dto.TabName;
                entity.IsActive = true;
                return entity;
            }

            // Edit UserRight DTO Mapper
            public static UserRight UserRightDTOToEditEntityMapper(UserRight entity, UserRightRequestDTO dto)
            {
                entity.UserRightCode = dto.UserRightCode;
                entity.UserRightName = dto.UserRightName;
                entity.URL = dto.URL;
                entity.TabName = dto.TabName;
                entity.UpdatedAt = DateTime.Now;
                return entity;
            }

            // Response DTO Mapper
            public static UserRightResponseDTO EntityToUserRightDTO(UserRight entity)
            {
                UserRightResponseDTO dto = new UserRightResponseDTO();
                dto.Id = entity.Id;
                dto.UserRightCode = entity.UserRightCode;
                dto.UserRightName = entity.UserRightName;
                dto.URL = entity.URL;
                dto.TabName = entity.TabName;
                dto.IsActive = entity.IsActive;
                dto.GlobalId = entity.GlobalId;
                dto.CreatedAt = DateTime.Now;
                dto.UpdatedAt = DateTime.Now;
               
                return dto;
            }

            // List Mapper
            public static List<UserRightResponseDTO> EntitiesToUserRightDTOs(List<UserRight> entities)
            {
                List<UserRightResponseDTO> list = new List<UserRightResponseDTO>();
                foreach (var entity in entities)
                {
                    list.Add(EntityToUserRightDTO(entity));
                }
                return list;
            }
        }
    }


