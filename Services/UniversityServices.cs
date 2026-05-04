using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;
using UniversityManagmentSystem.DTOMappers;

namespace UniversityManagmentSystem.Services
{
    public class UniversityServices
    {
        private readonly IUniversityRepository _universityRepository;
        public UniversityServices(IUniversityRepository universityRepository , ISubjectRepository subjectRepository)
        {
            _universityRepository = universityRepository;
           
        }

        public University AddUniversity(UniversityRequestDTO request)
        {
            University university = UniversityDTOMapper.UniversityDTOToEntityMapper(request);
            university.CreatedAt = DateTime.Now;
            _universityRepository.Add(university);
            _universityRepository.Save();
            return university;
        }

        
        public List<UniversityResponseDTO> GetAll()
        {
            List<University> universitys = _universityRepository.GetAll().ToList();
            return UniversityDTOMapper.EntitiesToUniversityDTOs(universitys);
        }

        public bool RemoveUniversity(int? id)
        {
            University university = _universityRepository.Get(ans => ans.Id == id);
            _universityRepository.Remove(university);
            _universityRepository.Save();
            return true;
        }
    }
}
