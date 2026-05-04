using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class SubjectService
    {
        private readonly ISubjectRepository _subjectRepository;
        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }
        public Subject AddSubject(SubjectRequestDTO request)
        {
            Subject subject = SubjectDTOMappers.SubjectDTOToEntityMappers(request);
            subject.CreatedAt = DateTime.Now;
            _subjectRepository.Add(subject);
            _subjectRepository.Save();
            return subject;
        }
        // Get All Subjects
        public List<SubjectResponseDTO> GetAll()
        {
            List<Subject> subjects = _subjectRepository.GetAll().ToList();
            return SubjectDTOMappers.EntityToSubjectDTOs(subjects);
        }
        // Remove Subject
        public bool RemoveSubject(int? id)
        {
            Subject subject = _subjectRepository.Get(ans => ans.Id == id);
            _subjectRepository.Remove(subject);
            _subjectRepository.Save();
            return true;
        }
    }
}
