using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;
using UniversityManagmentSystem.DTOMappers;

namespace UniversityManagmentSystem.Services
{
    public class CampusServices
    {
        private readonly ICampusRepository _campusRepository;

        public CampusServices(ICampusRepository campusRepository)
        {
            _campusRepository = campusRepository;
        }

        public Campus AddCampus(CampusRequestDTO request)
        {
            Campus campus = CampusDTOMappers.CampusDTOToEntityMapper(request);
            campus.CreatedAt = DateTime.Now;
            _campusRepository.Add(campus);
            _campusRepository.Save();
            return campus;
        }

        public Campus EditCampus(CampusRequestDTO request)
        {
            Campus campus = _campusRepository.Get(c => c.Id == request.Id);           
            campus = CampusDTOMappers.CampusDTOToEditEntityMapper(campus, request);
            _campusRepository.Update(campus);
            _campusRepository.Save();
            return campus;
        }

        public List<CampusResponseDTO> GetAll()
        {
            List<Campus> campuses = _campusRepository.GetAll().ToList();
            return CampusDTOMappers.EntitiesToCampusDTOs(campuses);
        }


        public bool RemoveCampus(int? id)
        {
            Campus campus = _campusRepository.Get(c => c.Id == id);
            _campusRepository.Remove(campus);
            _campusRepository.Save();
            return true;
        }
    }
}
