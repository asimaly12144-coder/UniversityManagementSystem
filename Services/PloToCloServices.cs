using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class PloToCloServices
    {
        private readonly IPloToCloRepository _repo;

        public PloToCloServices(IPloToCloRepository repo)
        {
            _repo = repo;
        }

        public PloToClo AddPloToClo(PloToCloRequestDTO request)
        {
            var entity = PloToCloDTOMappers.PloToCloDTOToEntityMapper(request);
            entity.CreatedAt = DateTime.Now;
            _repo.Add(entity);
            _repo.Save();
            return entity;
        }

        public List<PloToCloResponse> GetAll()
        {
            var entities = _repo.GetAll().ToList();
            return PloToCloDTOMappers.EntitiesToPloToCloDTOs(entities);
        }

        public bool RemovePloToClo(int? id)
        {
            var entity = _repo.Get(e => e.Id == id);
            _repo.Remove(entity);
            _repo.Save();
            return true;
        }
    }

}
