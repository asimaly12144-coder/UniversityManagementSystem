using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class RoomTypeAllocationServices
    {
        private readonly IRoomTypeAllocationRepository _roomTypeAllocationRepository;

        public RoomTypeAllocationServices(IRoomTypeAllocationRepository roomTypeAllocationRepository)
        {
            _roomTypeAllocationRepository = roomTypeAllocationRepository;
        }

        public RoomTypeAllocation AddRoomTypeAllocation(RoomTypeAllocationRequest request)
        {
            var entity = RoomTypeAllocationDTOMappers.RoomTypeAllocationDTOToEntityMapper(request);
            entity.CreatedAt = DateTime.Now;
            _roomTypeAllocationRepository.Add(entity);
            _roomTypeAllocationRepository.Save();
            return entity;
        }

        public List<RoomTypeAllocationResponseDTO> GetAll()
        {
            var entities = _roomTypeAllocationRepository.GetAll().ToList();
            return RoomTypeAllocationDTOMappers.EntitiesToRoomTypeAllocationDTOs(entities);
        }

        public bool RemoveRoomTypeAllocation(int? id)
        {
            var entity = _roomTypeAllocationRepository.Get(e => e.Id == id);
            _roomTypeAllocationRepository.Remove(entity);
            _roomTypeAllocationRepository.Save();
            return true;
        }
    }

}
