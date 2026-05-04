using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class SubjectTypeService
    {
        private readonly ISubjectTypeRepository _subjectTypeRepository;
        public SubjectTypeService(ISubjectTypeRepository subjectTypeRepository)
        {
            _subjectTypeRepository = subjectTypeRepository;
        }
        public SubjectType AddSubjectType(SubjectTypeRequestDTO request)
        {
            SubjectType subjectType = SubjectTypeDTOMappers.SubjectTypeDTOToEntityMappers(request);
            subjectType.CreatedAt = DateTime.Now;
            _subjectTypeRepository.Add(subjectType);
            _subjectTypeRepository.Save();
            return subjectType;
        }
        public List<SubjectTypeResponseDTO> GetAll()
        {
            List<SubjectType> subjectTypes = _subjectTypeRepository.GetAll().ToList();
            return SubjectTypeDTOMappers.EntitiesToSubjectTypeDTOs(subjectTypes);
        }

        // Remove 

        public bool RemoveSubjectType(int? id)
        {
            SubjectType subjectType = _subjectTypeRepository.Get(ans => ans.Id == id);
            _subjectTypeRepository.Remove(subjectType);
            _subjectTypeRepository.Save();
            return true;

        }
    }
}
