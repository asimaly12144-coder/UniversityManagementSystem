using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class SemesterService
    {
        private readonly ISemesterRepository _semesterRepository;
        public SemesterService(ISemesterRepository semesterRepository)
        {
            _semesterRepository = semesterRepository;
        }
        public Semester AddSemster(SemesterRequestDTO request)
        {
            Semester semester = SemesterDTOMappers.SemesterDTOToEntityMappers(request);
            semester.CreatedAt = DateTime.Now;
            _semesterRepository.Add(semester);
            _semesterRepository.Save();
            return semester;
        }
        // Get All Semesters

        public List<SemesterResponseDTO> GetAll()
        {
            List<Semester> semesters = _semesterRepository.GetAll().ToList();
            return SemesterDTOMappers.EntitiesToSemesterDTOs(semesters);
        }
        // Remove Semester
        public bool RemoveSemester(int? id)
        {
            Semester semester = _semesterRepository.Get(ans => ans.Id == id);            
            _semesterRepository.Remove(semester);
            _semesterRepository.Save();
            return true;
        }

    }
}
