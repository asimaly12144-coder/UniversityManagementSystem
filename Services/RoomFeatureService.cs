using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;
namespace UniversityManagmentSystem.Services
{
    public class RoomFeatureService
    {
        private readonly IRoomFeatureRepository _roomFeatureRepository;

        public RoomFeatureService(IRoomFeatureRepository roomFeatureRepository)
        {
            _roomFeatureRepository = roomFeatureRepository;
        }
        public RoomFeature AddRoomFeature(RoomFeatureRequestDTO request)
        {
            RoomFeature roomFeature = RoomFeatureDTOMappers.RoomFeatureDTOToEntityMappers(request);
            roomFeature.CreatedAt = DateTime.Now;
            _roomFeatureRepository.Add(roomFeature);
            _roomFeatureRepository.Save();
            return roomFeature;
        }

        // GetAll RoomFeatures

        public List<RoomFeatureResponseDTO> GetAll()
        {
            List<RoomFeature> roomFeatures = _roomFeatureRepository.GetAll().ToList();
            return RoomFeatureDTOMappers.EntitiesToRoomFeatureDTOs(roomFeatures);
        }
        // Remove RoomFeature
        public bool RemoveRoomFeature(int? id)
        {
            RoomFeature roomFeature = _roomFeatureRepository.Get(ans => ans.Id == id);
            _roomFeatureRepository.Remove(roomFeature);
            _roomFeatureRepository.Save();
            return true;
        }
    }
}
