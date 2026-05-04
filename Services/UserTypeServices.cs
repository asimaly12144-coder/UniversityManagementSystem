using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class UserTypeServices
    {
        private readonly IUserTypeRepository _userTypeRepository;
        public UserTypeServices(IUserTypeRepository userTypeRepository)
        {
            _userTypeRepository = userTypeRepository;
        }
        public UserType AddUserType(UserTypeRequestDTO userTypeName)
        {
            UserType userType = UserTypeDTOMappers.UserTypeDTOToEntityMapper(userTypeName);
            _userTypeRepository.Add(userType);
            _userTypeRepository.Save();
            return userType;
        }
        public List<UserTypeResponseDTO> GetAll()
        {
            List<UserType> userTypes = _userTypeRepository.GetAll().ToList();
            return UserTypeDTOMappers.EntitiesToUserTypeDTOs(userTypes);
        }
        public bool Remove(int? Id)
        {
            UserType userType = _userTypeRepository.Get(id => id.Id == Id);

            _userTypeRepository.Remove(userType);
            _userTypeRepository.Save();
            return true;

        }
    }
}
