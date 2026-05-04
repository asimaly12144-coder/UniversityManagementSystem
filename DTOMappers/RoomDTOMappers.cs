using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class RoomDTOMappers
    {
        // Create Room DTO Mapper
        public static Room RoomDTOToEntityMapper(RoomRequestDTO dto)
        {
            Room room = new Room();
            room.RoomName = dto.RoomName;
            room.Code = dto.Code;
            room.Description = dto.Description;
            room.EstablishedIn = dto.EstablishedIn;
            room.FloorId = dto.FloorId;
            room.IsActive = true;
            return room;
        }

        // Edit Room DTO Mapper
        public static Room RoomDTOToEditEntityMapper(Room room, RoomRequestDTO dto)
        {
            room.RoomName = dto.RoomName;
            room.Code = dto.Code;
            room.Description = dto.Description;
            room.EstablishedIn = dto.EstablishedIn;
            room.FloorId = dto.FloorId;
            room.UpdatedAt = DateTime.Now;
            return room;
        }

        // Entity to Response DTO
        public static RoomResponseDTO EntityToRoomDTO(Room room)
        {
            RoomResponseDTO dto = new RoomResponseDTO();
            dto.Id = room.Id;
            dto.RoomName = room.RoomName;
            dto.Code = room.Code;
            dto.Description = room.Description;
            dto.EstablishedIn = room.EstablishedIn;
            dto.FloorId = room.FloorId;

            dto.IsActive = room.IsActive;
            dto.GlobalId = room.GlobalId;
            dto.CreatedAt = room.CreatedAt;
            dto.UpdatedAt = room.UpdatedAt;
            dto.DeletedAt = room.DeletedAt;
            dto.CreatedBy = room.CreatedBy;
            dto.UpdatedBy = room.UpdatedBy;
            dto.DeletedBy = room.DeletedBy;

            return dto;
        }

        // List of RoomResponseDTO Mapper
        public static List<RoomResponseDTO> EntitiesToRoomDTOs(List<Room> rooms)
        {
            List<RoomResponseDTO> responseList = new List<RoomResponseDTO>();
            foreach (Room room in rooms)
            {
                RoomResponseDTO dto = EntityToRoomDTO(room);
                responseList.Add(dto);
            }
            return responseList;
        }
    }
}
