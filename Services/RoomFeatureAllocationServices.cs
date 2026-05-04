using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class RoomFeatureAllocationServices
    {
        private readonly IRoomFeatureAllocationRepository _repo;

        public RoomFeatureAllocationServices(IRoomFeatureAllocationRepository repo)
        {
            _repo = repo;
        }

        public RoomFeatureAllocation AddRoomFeatureAllocation(RoomFeatureAllocationRequestDTO request)
        {
            var entity = RoomFeatureAllocationDTOMappers.RoomFeatureAllocationDTOToEntityMapper(request);
            entity.CreatedAt = DateTime.Now;
            _repo.Add(entity);
            _repo.Save();
            return entity;
        }

        public List<RoomFeatureAllocationResponseDTO> GetAll()
        {
            var entities = _repo.GetAll().ToList();
            return RoomFeatureAllocationDTOMappers.EntitiesToRoomFeatureAllocationDTOs(entities);
        }

        public bool RemoveRoomFeatureAllocation(int? id)
        {
            var entity = _repo.Get(e => e.Id == id);
            _repo.Remove(entity);
            _repo.Save();
            return true;
        }
    }

}
