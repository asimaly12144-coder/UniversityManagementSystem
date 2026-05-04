using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class StructureUnitServices
    {
        private readonly IStructureUnitRepository _structureUnitRepository;

        public StructureUnitServices(IStructureUnitRepository structureUnitRepository)
        {
            _structureUnitRepository = structureUnitRepository;
        }

        public StructureUnit AddStructureUnit(StructureUnitRequestDTO request)
        {
            var entity = StructureUnitDTOMappers.StructureUnitDTOToEntityMapper(request);
            entity.CreatedAt = DateTime.Now;
            _structureUnitRepository.Add(entity);
            _structureUnitRepository.Save();
            return entity;
        }

        public List<StructureUnitResponseDTO> GetAll()
        {
            var entities = _structureUnitRepository.GetAll().ToList();
            return StructureUnitDTOMappers.EntitiesToStructureUnitDTOs(entities);
        }

        public bool RemoveStructureUnit(int? id)
        {
            var entity = _structureUnitRepository.Get(e => e.Id == id);
            _structureUnitRepository.Remove(entity);
            _structureUnitRepository.Save();
            return true;
        }
    }

}
