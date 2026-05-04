using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class StructureTypeService
    {
        private readonly IStructureTypeRepository _structureTypeRepository;

        public StructureTypeService(IStructureTypeRepository structureTypeRepository)
        {
            _structureTypeRepository = structureTypeRepository;
        }

        public StructureType AddStructureType(StructureTypeRequestDTO request)
        {
            StructureType structureType = StructureTypeDTOMappers.StructureTypeDTOToEntityMappers(request);
            structureType.CreatedAt = DateTime.Now;
            structureType.UpdatedAt = DateTime.Now;
            structureType.IsActive = true;
            _structureTypeRepository.Add(structureType);
            _structureTypeRepository.Save();
            return structureType;
        }

        // Get All Structure Types
        public List<StructureTypeResponseDTO> GetAll()
        {
            List<StructureType> structureTypes = _structureTypeRepository.GetAll().ToList();
            return StructureTypeDTOMappers.EntityToSturctureTypeDTOs(structureTypes);
        }

        // Remove Structure Type
        public bool RemoveStructureType(int? id)
        {
            StructureType structureType = _structureTypeRepository.Get(ans => ans.Id == id);
            _structureTypeRepository.Remove(structureType);
            _structureTypeRepository.Save();
            return true;
        }
    }
}
