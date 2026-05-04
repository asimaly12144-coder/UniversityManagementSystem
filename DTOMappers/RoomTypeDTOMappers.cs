using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class RoomTypeDTOMappers
    {
        // Create 
        public static RoomType RoomTypeDTOToEntityMappers(RoomTypeRequestDTO roomTypeRequestDTO)
        {
            RoomType roomType = new RoomType();
            roomType.RoomTypeName = roomTypeRequestDTO.RoomTypeName;
            roomType.Code = roomTypeRequestDTO.Code;
            roomType.Description = roomTypeRequestDTO.Description;
            return roomType;
        }

        // Edit DTO Mapper
        public static RoomType RoomTypeDTOToEditEntityMappers(RoomType roomType, RoomTypeRequestDTO roomTypeRequestDTO)
        {
            roomType.RoomTypeName = roomTypeRequestDTO.RoomTypeName;
            roomType.Code = roomTypeRequestDTO.Code;
            roomType.Description = roomTypeRequestDTO.Description;
            roomType.UpdatedAt = DateTime.Now;
            return roomType;
        }
        // Response DTO Mapper
        public static RoomTypeResponseDTO EntityToRoomTypeDTO(RoomType roomType)
        {
            RoomTypeResponseDTO roomTypeResponseDTO = new RoomTypeResponseDTO();
            roomTypeResponseDTO.Id = roomType.Id;
            roomTypeResponseDTO.RoomTypeName = roomType.RoomTypeName;
            roomTypeResponseDTO.Code = roomType.Code;
            roomTypeResponseDTO.Description = roomType.Description;
            roomTypeResponseDTO.CreatedAt = DateTime.Now;
            roomTypeResponseDTO.UpdatedAt = DateTime.Now;
            roomTypeResponseDTO.GlobalId = roomType.GlobalId;
            return roomTypeResponseDTO;
        }
        // List of RoomTypeResponseDTO Mapper
        public static List<RoomTypeResponseDTO> EntitiesToRoomTypeDTOs(List<RoomType> roomTypes)
        {
            List<RoomTypeResponseDTO> roomTypeResponseDTOs = new List<RoomTypeResponseDTO>();
            foreach (RoomType roomType in roomTypes)
            {
                RoomTypeResponseDTO roomTypeResponseDTO = EntityToRoomTypeDTO(roomType);
                roomTypeResponseDTOs.Add(roomTypeResponseDTO);
            }
            return roomTypeResponseDTOs;
        }
    }
}
