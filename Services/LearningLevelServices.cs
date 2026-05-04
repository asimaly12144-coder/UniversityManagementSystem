using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class LearningLevelServices
    {
        private readonly ILearningLevelRepository _repo;

        public LearningLevelServices(ILearningLevelRepository repo)
        {
            _repo = repo;
        }

        public LearningLevel AddLearningLevel(LearningLevelRequestDTO request)
        {
            var entity = LearningLevelDTOMappers.LearningLevelDTOToEntityMapper(request);
            entity.CreatedAt = DateTime.Now;
            _repo.Add(entity);
            _repo.Save();
            return entity;
        }

        public List<LearningLevelResponseDTO> GetAll()
        {
            var entities = _repo.GetAll().ToList();
            return LearningLevelDTOMappers.EntitiesToLearningLevelDTOs(entities);
        }

        public bool RemoveLearningLevel(int? id)
        {
            var entity = _repo.Get(e => e.Id == id);
            _repo.Remove(entity);
            _repo.Save();
            return true;
        }
    }

}
