using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class FloorServices
    {
        private readonly IFloorRepository _repo;

        public FloorServices(IFloorRepository repo)
        {
            _repo = repo;
        }

        public Floor AddFloor(FloorRequestDTO request)
        {
            var entity = FloorDTOMappers.FloorDTOToEntityMapper(request);
            entity.CreatedAt = DateTime.Now;
            _repo.Add(entity);
            _repo.Save();
            return entity;
        }

        public List<FloorResponseDTO> GetAll()
        {
            var entities = _repo.GetAll().ToList();
            return FloorDTOMappers.EntitiesToFloorDTOs(entities);
        }

        public bool RemoveFloor(int? id)
        {
            var entity = _repo.Get(e => e.Id == id);
            _repo.Remove(entity);
            _repo.Save();
            return true;
        }
    }

}
