using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class FacultyService
    {
        private readonly IFacultyRepository _facultyRepository;

        public FacultyService(IFacultyRepository facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }
        public Faculty AddService(FacultyRequestDTO request)
        {
            Faculty faculty = FacultyDTOMappers.FacultyDTOToEntityMappers(request);
            faculty.CreatedAt = DateTime.Now;
            _facultyRepository.Add(faculty);
            _facultyRepository.Save();
            return faculty;

        }
        // GetAll
        public List<FacultyResponseDTO> GetAll()
        {
            List<Faculty> faculties = _facultyRepository.GetAll().ToList();
            return FacultyDTOMappers.EntityToFacultyDTOs(faculties);
        }

        // Remove

        public bool RemoveFaculty(int? Id)
        {
            Faculty faculty =_facultyRepository.Get(ans => ans.Id == Id);
            _facultyRepository.Remove(faculty);
            _facultyRepository.Save();
            return true;
        }
    }
}
