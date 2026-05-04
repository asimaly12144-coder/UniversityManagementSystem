using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class StructureTypeDTOMappers
    {
        // Create To DTO Mapper
        public static StructureType StructureTypeDTOToEntityMappers(StructureTypeRequestDTO structureTypeRequestDTO)
        {
            StructureType structureType = new StructureType();
            structureType.Description = structureTypeRequestDTO.Description;
            structureType.StructureTypeName = structureTypeRequestDTO.StructureTypeName;
            structureType.Code = structureTypeRequestDTO.Code;
            return structureType;
        }
        // Edit To DTO Mapper
        public static StructureType StructureTypeDTOToEditEntityMappers(StructureType structureType, StructureTypeRequestDTO structureTypeRequestDTO)
        {
            structureType.Description = structureTypeRequestDTO.Description;
            structureType.StructureTypeName = structureTypeRequestDTO.StructureTypeName;
            structureType.Code = structureTypeRequestDTO.Code;
            structureType.UpdatedAt = DateTime.Now;
            return structureType;
        }

        // Response DTO Mapper
        public static StructureTypeResponseDTO EntityToStructureTypeDTO(StructureType structureType)
        {
            StructureTypeResponseDTO structureTypeResponseDTO = new StructureTypeResponseDTO();
            structureTypeResponseDTO.Id = structureType.Id;
            structureTypeResponseDTO.StructureTypeName = structureType.StructureTypeName;
            structureTypeResponseDTO.Code = structureType.Code;
            structureTypeResponseDTO.Description = structureType.Description;
            structureTypeResponseDTO.CreatedAt = DateTime.Now;
            structureTypeResponseDTO.UpdatedAt = DateTime.Now;
            structureTypeResponseDTO.GlobalId = structureType.GlobalId;
            return structureTypeResponseDTO;
        }
        // List 

        public static List<StructureTypeResponseDTO> EntityToSturctureTypeDTOs(List<StructureType> structureTypes)
        {
            List<StructureTypeResponseDTO> structureTypeRequestDTOs = new List<StructureTypeResponseDTO>();
            foreach(StructureType structureType in structureTypes)
            {
                StructureTypeResponseDTO structureTypeResponseDTO = EntityToStructureTypeDTO(structureType);
                structureTypeRequestDTOs.Add(structureTypeResponseDTO);
            }
            return structureTypeRequestDTOs;
        }
    }
}
