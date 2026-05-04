using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class PloServices
    {
        private readonly IPLORepository _ploRepository;

        public PloServices(IPLORepository ploRepository)
        {
            _ploRepository = ploRepository;
        }

        public ProgramLearningOutcomes AddPlo(PloRequestDTO request)
        {
            var entity = PLODTOMappers.PloDTOToEntityMapper(request);
            entity.CreatedAt = DateTime.Now;
            _ploRepository.Add(entity);
            _ploRepository.Save();
            return entity;
        }

        public List<PloResponseDTO> GetAll()
        {
            var entities = _ploRepository.GetAll().ToList();
            return PLODTOMappers.EntitiesToPloDTOs(entities);
        }

        public bool RemovePlo(int? id)
        {
            var entity = _ploRepository.Get(e => e.Id == id);
            _ploRepository.Remove(entity);
            _ploRepository.Save();
            return true;
        }
    }

}
