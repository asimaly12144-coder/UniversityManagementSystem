using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;
using UniversityManagmentSystem.Repositories;

namespace UniversityManagmentSystem.Services
{
    public class RoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository;
        public RoomTypeService(IRoomTypeRepository roomTypeRepository)
        {
            _roomTypeRepository = roomTypeRepository;
        }
        public RoomType AddRoomType(RoomTypeRequestDTO request)
        {
            RoomType roomType = RoomTypeDTOMappers.RoomTypeDTOToEntityMappers(request);
            roomType.CreatedAt= DateTime.Now;
            _roomTypeRepository.Add(roomType);
            _roomTypeRepository.Save();
            return roomType;
        }
        // Get All Room Types
        public List<RoomTypeResponseDTO> GetAll()
        {
            List<RoomType> roomTypes = _roomTypeRepository.GetAll().ToList();
            return RoomTypeDTOMappers.EntitiesToRoomTypeDTOs(roomTypes);
        }
        // Remove Room Type
        public bool RemoveRoomType(int? id)
        {
            RoomType roomType = _roomTypeRepository.Get(ans => ans.Id == id);
            _roomTypeRepository.Remove(roomType);
            _roomTypeRepository.Save();
            return true;
        }
    }
}
