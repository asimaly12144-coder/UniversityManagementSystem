using UniversityManagmentSystem.Data;
using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class DegreeLevelService
    {
        private readonly IDegreeLevelRepository _degreeLevelRepository;
        public DegreeLevelService(IDegreeLevelRepository degreeLevelRepository)
        {
            _degreeLevelRepository = degreeLevelRepository;
        }
        public DegreeLevel AddDegreeLevel(DegreeLevelRequestDTO request)
        {
            DegreeLevel degreeLevel = DegreeLevelDTOMappers.DegreeLevelDTOToEntityMapper(request);
            degreeLevel.CreatedAt = DateTime.Now;
            _degreeLevelRepository.Add(degreeLevel);
            _degreeLevelRepository.Save();
            return degreeLevel;
        }
        //GetAll DegreeLevels

        public List<DegreeLevelResponseDTO> GetAll()
        {
            List<DegreeLevel> degreeLevels = _degreeLevelRepository.GetAll().ToList();
            return DegreeLevelDTOMappers.EntitiesToDegreeLevelDTOs(degreeLevels);
        }

        //Remove DegreeLevel
        public bool RemoveDegreeLevel(int? id)
        {
            DegreeLevel degreeLevel = _degreeLevelRepository.Get(ans => ans.Id == id);
            _degreeLevelRepository.Remove(degreeLevel);
            _degreeLevelRepository.Save();
            return true;
        }
    }
}
