using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class RoomServices
    {
        private readonly IRoomRepository _roomRepository;

        public RoomServices(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public Room AddRoom(RoomRequestDTO request)
        {
            var entity = RoomDTOMappers.RoomDTOToEntityMapper(request);
            entity.CreatedAt = DateTime.Now;
            _roomRepository.Add(entity);
            _roomRepository.Save();
            return entity;
        }

        public List<RoomResponseDTO> GetAll()
        {
            var entities = _roomRepository.GetAll().ToList();
            return RoomDTOMappers.EntitiesToRoomDTOs(entities);
        }

        public bool RemoveRoom(int? id)
        {
            var entity = _roomRepository.Get(e => e.Id == id);
            _roomRepository.Remove(entity);
            _roomRepository.Save();
            return true;
        }
    }

}
