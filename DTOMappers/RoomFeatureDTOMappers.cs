using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class RoomFeatureDTOMappers
    {

        // To Create RoomFeature Entity from RoomFeatureRequestDTO
        public static RoomFeature RoomFeatureDTOToEntityMappers(RoomFeatureRequestDTO roomFeatureRequestDTO)
        {
            RoomFeature roomFeature = new RoomFeature();
            roomFeature.RoomFeatureName = roomFeatureRequestDTO.RoomFeatureName;
            roomFeature.Code = roomFeatureRequestDTO.Code;
            roomFeature.Description = roomFeatureRequestDTO.Description;
            return roomFeature;
            
        }

        //To Edit RoomFeature Entity

        public static RoomFeature RoomFeatureDTOToEditEntityMappers(RoomFeature roomFeature, RoomFeatureRequestDTO roomFeatureRequestDTO)
        {
            roomFeature.RoomFeatureName = roomFeatureRequestDTO.RoomFeatureName;
            roomFeature.Code = roomFeatureRequestDTO.Code;
            roomFeature.Description = roomFeatureRequestDTO.Description;
            roomFeature.UpdatedAt = DateTime.Now;
            return roomFeature;
        }

        

        // Response DTO Mapper

        public static RoomFeatureResponseDTO EntityToRoomFeatureDTO(RoomFeature roomFeature)
        {
            RoomFeatureResponseDTO roomFeatureResponseDTO = new RoomFeatureResponseDTO();
            roomFeatureResponseDTO.Id = roomFeature.Id;
            roomFeatureResponseDTO.RoomFeatureName = roomFeature.RoomFeatureName;
            roomFeatureResponseDTO.Code = roomFeature.Code;
            roomFeatureResponseDTO.Description = roomFeature.Description;
            roomFeatureResponseDTO.CreatedAt = DateTime.Now;
            roomFeatureResponseDTO.UpdatedAt = DateTime.Now;
            roomFeatureResponseDTO.GlobalId = roomFeature.GlobalId;
            return roomFeatureResponseDTO;
        }

        // List of RoomFeatureResponseDTO Mapper

        public static List<RoomFeatureResponseDTO> EntitiesToRoomFeatureDTOs(List<RoomFeature> roomFeatures)
        {
            List<RoomFeatureResponseDTO> roomFeatureResponseDTOs = new List<RoomFeatureResponseDTO>();
            foreach (RoomFeature roomFeature in roomFeatures)
            {
                RoomFeatureResponseDTO roomFeatureResponseDTO = EntityToRoomFeatureDTO(roomFeature);
                roomFeatureResponseDTOs.Add(roomFeatureResponseDTO);
            }
            return roomFeatureResponseDTOs;
        }

    }
}
