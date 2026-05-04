using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class PeoServices
    {
        private readonly IPEORepository _repo;

        public PeoServices(IPEORepository repo)
        {
            _repo = repo;
        }

        public ProgramEductionOutcomes AddPeo(PeoRequestDTO request)
        {
            var entity = PEODTOMappers.PeoDTOToEntityMapper(request);
            entity.CreatedAt = DateTime.Now;
            _repo.Add(entity);
            _repo.Save();
            return entity;
        }

        public List<PeoResponseDTO> GetAll()
        {
            var entities = _repo.GetAll().ToList();
            return PEODTOMappers.EntitiesToPeoDTOs(entities);
        }

        public bool RemovePeo(int? id)
        {
            var entity = _repo.Get(e => e.Id == id);
            _repo.Remove(entity);
            _repo.Save();
            return true;
        }
    }

}
