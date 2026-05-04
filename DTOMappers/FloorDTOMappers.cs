using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class FloorDTOMappers
    {
        // Create Floor DTO Mapper
        public static Floor FloorDTOToEntityMapper(FloorRequestDTO dto)
        {
            Floor floor = new Floor();
            floor.FloorName = dto.FloorName;
            floor.Code = dto.Code;
            floor.Description = dto.Description;
            floor.EstablishedIn = dto.EstablishedIn;
            floor.BuildingId = dto.BuildingId;
            floor.IsActive = true;
            return floor;
        }

        // Edit Floor DTO Mapper
        public static Floor FloorDTOToEditEntityMapper(Floor floor, FloorRequestDTO dto)
        {
            floor.FloorName = dto.FloorName;
            floor.Code = dto.Code;
            floor.Description = dto.Description;
            floor.EstablishedIn = dto.EstablishedIn;
            floor.BuildingId = dto.BuildingId;
            floor.UpdatedAt = DateTime.Now;
            return floor;
        }

        // Entity to Response DTO
        public static FloorResponseDTO EntityToFloorDTO(Floor floor)
        {
            FloorResponseDTO dto = new FloorResponseDTO();
            dto.Id = floor.Id;
            dto.FloorName = floor.FloorName;
            dto.Code = floor.Code;
            dto.Description = floor.Description;
            dto.EstablishedIn = floor.EstablishedIn;
            dto.BuildingId = floor.BuildingId;

            dto.IsActive = floor.IsActive;
            dto.GlobalId = floor.GlobalId;
            dto.CreatedAt = floor.CreatedAt;
            dto.UpdatedAt = floor.UpdatedAt;
            dto.DeletedAt = floor.DeletedAt;
            dto.CreatedBy = floor.CreatedBy;
            dto.UpdatedBy = floor.UpdatedBy;
            dto.DeletedBy = floor.DeletedBy;

            return dto;
        }

        // List of FloorResponseDTO Mapper
        public static List<FloorResponseDTO> EntitiesToFloorDTOs(List<Floor> floors)
        {
            List<FloorResponseDTO> responseList = new List<FloorResponseDTO>();
            foreach (Floor floor in floors)
            {
                FloorResponseDTO dto = EntityToFloorDTO(floor);
                responseList.Add(dto);
            }
            return responseList;
        }
    }
}
