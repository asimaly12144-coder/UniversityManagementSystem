using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class BuildingDTOMappers
    {
        // Create Building DTO Mapper
        public static Building BuildingDTOToEntityMapper(BuildingRequestDTO buildingDTO)
        {
            Building building = new Building();
            building.BuildingName = buildingDTO.BuildingName;
            building.Code = buildingDTO.Code;
            building.Description = buildingDTO.Description;
            building.EstablishedIn = buildingDTO.EstablishedIn;
            building.Address = buildingDTO.Address;
            building.BlockId = buildingDTO.BlockId;
            building.IsActive = true;
            return building;
        }

        // Edit Building DTO Mapper
        public static Building BuildingDTOToEditEntityMapper(Building building, BuildingRequestDTO buildingDTO)
        {
            building.BuildingName = buildingDTO.BuildingName;
            building.Code = buildingDTO.Code;
            building.Description = buildingDTO.Description;
            building.EstablishedIn = buildingDTO.EstablishedIn;
            building.Address = buildingDTO.Address;
            building.BlockId = buildingDTO.BlockId;
            building.UpdatedAt = DateTime.Now;
            return building;
        }

        // Entity to Response DTO
        public static BuildingResponseDTO EntityToBuildingDTO(Building building)
        {
            BuildingResponseDTO buildingResponseDTO = new BuildingResponseDTO();
            buildingResponseDTO.Id = building.Id;
            buildingResponseDTO.BuildingName = building.BuildingName;
            buildingResponseDTO.Code = building.Code;
            buildingResponseDTO.Description = building.Description;
            buildingResponseDTO.EstablishedIn = building.EstablishedIn;
            buildingResponseDTO.Address = building.Address;
            buildingResponseDTO.BlockId = building.BlockId;

            buildingResponseDTO.IsActive = building.IsActive;
            buildingResponseDTO.GlobalId = building.GlobalId;
            buildingResponseDTO.CreatedAt = building.CreatedAt;
            buildingResponseDTO.UpdatedAt = building.UpdatedAt;
            buildingResponseDTO.DeletedAt = building.DeletedAt;
            buildingResponseDTO.CreatedBy = building.CreatedBy;
            buildingResponseDTO.UpdatedBy = building.UpdatedBy;
            buildingResponseDTO.DeletedBy = building.DeletedBy;

            return buildingResponseDTO;
        }

        // List of BuildingResponseDTO Mapper
        public static List<BuildingResponseDTO> EntitiesToBuildingDTOs(List<Building> buildings)
        {
            List<BuildingResponseDTO> buildingResponseDTOs = new List<BuildingResponseDTO>();
            foreach (Building building in buildings)
            {
                BuildingResponseDTO buildingResponseDTO = EntityToBuildingDTO(building);
                buildingResponseDTOs.Add(buildingResponseDTO);
            }
            return buildingResponseDTOs;
        }
    }
}
