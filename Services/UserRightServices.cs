using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class UserRightServices
    {
        private readonly IUserRightRepository _userRightRepository;
        public UserRightServices(IUserRightRepository userRightRepository)
        {
            _userRightRepository = userRightRepository;
        }
        public UserRight AddUserRight(UserRightRequestDTO request)
        {
            UserRight userRight = UserRightDTOMappers.UserRightDTOToEntityMapper(request);
            _userRightRepository.Add(userRight);
            _userRightRepository.Save();
            return userRight;
        }
        public List<UserRightResponseDTO> GetAll()
        {
            List<UserRight> userRights = _userRightRepository.GetAll().ToList();
            return UserRightDTOMappers.EntitiesToUserRightDTOs(userRights);
        }
        public bool Remove(int? Id)
        {
            UserRight userRight = _userRightRepository.Get(ans => ans.Id == Id);
            _userRightRepository.Remove(userRight);
            _userRightRepository.Save();
            return true;
        }
    }
}
