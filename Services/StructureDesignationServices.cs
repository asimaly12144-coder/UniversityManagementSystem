using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class StructureDesignationServices
    {
        private readonly IStructureDesignationRepository _structureDesignationRepository;

        public StructureDesignationServices(IStructureDesignationRepository structureDesignationRepository)
        {
            _structureDesignationRepository = structureDesignationRepository;
        }

        public StructureDesignation AddStructureDesignation(StructureDesignationRequestDTO request)
        {
            var entity = StructureDesignationDTOMappers.StructureDesignationDTOToEntityMapper(request);
            entity.CreatedAt = DateTime.Now;
            _structureDesignationRepository.Add(entity);
            _structureDesignationRepository.Save();
            return entity;
        }

        public List<StructureDesignationResponseDTO> GetAll()
        {
            var entities = _structureDesignationRepository.GetAll().ToList();
            return StructureDesignationDTOMappers.EntitiesToStructureDesignationDTOs(entities);
        }

        public bool RemoveStructureDesignation(int? id)
        {
            var entity = _structureDesignationRepository.Get(e => e.Id == id);
            _structureDesignationRepository.Remove(entity);
            _structureDesignationRepository.Save();
            return true;
        }
    }

}
