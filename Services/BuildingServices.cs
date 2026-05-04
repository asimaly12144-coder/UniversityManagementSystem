using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;
using UniversityManagmentSystem.DTOMappers;

namespace UniversityManagmentSystem.Services
{
    public class BuildingServices
    {
        private readonly IBuildingRepository _buildingRepository;

        public BuildingServices(IBuildingRepository buildingRepository)
        {
            _buildingRepository = buildingRepository;
        }

        public Building AddBuilding(BuildingRequestDTO request)
        {
            Building building = BuildingDTOMappers.BuildingDTOToEntityMapper(request);
            building.CreatedAt = DateTime.Now;
            _buildingRepository.Add(building);
            _buildingRepository.Save();
            return building;
        }

        public List<BuildingResponseDTO> GetAll()
        {
            List<Building> buildings = _buildingRepository.GetAll().ToList();
            return BuildingDTOMappers.EntitiesToBuildingDTOs(buildings);
        }

        public bool RemoveBuilding(int? id)
        {
            Building building = _buildingRepository.Get(b => b.Id == id);
            _buildingRepository.Remove(building);
            _buildingRepository.Save();
            return true;
        }
    }
}
