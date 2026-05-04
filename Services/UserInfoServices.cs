using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class UserInfoServices
    {
        private readonly IUserInfoRepository _userInfoRepository;
        public UserInfoServices(IUserInfoRepository userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }

        public UserInfo AddUserInfo(UserInfoRequestDTO userInfoReq)
        {
            UserInfo userInfo = UserInfoDTOMappers.UserInfoDTOToEntityMapper(userInfoReq);
            _userInfoRepository.Add(userInfo);
            _userInfoRepository.Save();
            return userInfo;
        }
        public List<UserInfoResponseDTO> GetAll()
        {
            List<UserInfo> userInfos = _userInfoRepository.GetAll().ToList();
            return UserInfoDTOMappers.EntitiesToUserInfoDTOs(userInfos);
        }
        public bool RemoveUserInfo(int? id)
        {
            UserInfo userInfo = _userInfoRepository.Get(ans => ans.Id == id);
            _userInfoRepository.Remove(userInfo);
            _userInfoRepository.Save();
            return true;

        }
    }
}
