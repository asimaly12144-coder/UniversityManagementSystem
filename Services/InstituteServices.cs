using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class InstituteServices
    {
        private readonly IInstituteRepository _repo;

        public InstituteServices(IInstituteRepository repo)
        {
            _repo = repo;
        }

        public Institute AddInstitute(InstituteRequestDTO request)
        {
            var entity = InstituteDTOMappers.InstituteDTOToEntityMapper(request);
            entity.CreatedAt = DateTime.Now;
            _repo.Add(entity);
            _repo.Save();
            return entity;
        }

        public List<InstituteResponseDTO> GetAll()
        {
            var entities = _repo.GetAll().ToList();
            return InstituteDTOMappers.EntitiesToInstituteDTOs(entities);
        }

        public bool RemoveInstitute(int? id)
        {
            var entity = _repo.Get(e => e.Id == id);
            _repo.Remove(entity);
            _repo.Save();
            return true;
        }
    }

}
