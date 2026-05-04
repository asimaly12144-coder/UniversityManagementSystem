using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class DesignationService
    {
        private readonly IDesignationRepository _designationRepository;

        public DesignationService(IDesignationRepository designationRepository)
        {
            _designationRepository = designationRepository;
        }
        public Designation AddDesignation(DesignationRequestDTO request)
        {
            Designation designation = DesignationDTOMappers.DesignationDTOToEntityMappers(request);
            designation.CreatedAt = DateTime.Now;
            _designationRepository.Add(designation);
            _designationRepository.Save();
            return designation;

        }
        // GetAll
        public List<DesignationResponseDTO> GetAll()
        {
            List<Designation> designations = _designationRepository.GetAll().ToList();
            return DesignationDTOMappers.EntitiesToDesignationDTOs(designations);
        }

        // Remove Designation
        public bool RemoveDesignation(int? id)
        {
            Designation designation = _designationRepository.Get(ans => ans.Id == id);
            _designationRepository.Remove(designation);
            _designationRepository.Save();
            return true;

        }
    }
}
