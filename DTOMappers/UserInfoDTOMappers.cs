using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class UserInfoDTOMappers
    {
        public static UserInfo UserInfoDTOToEntityMapper(UserInfoRequestDTO userInfoReq)
        {
            UserInfo userInfo = new UserInfo();   
            userInfo.Id = userInfoReq.Id;
            userInfo.UserName = userInfoReq.UserName;
            userInfo.UiUser = userInfoReq.UiUser;
            userInfo.UiPassword = userInfoReq.UiPassword;
            userInfo.CreatedAt = DateTime.Now;
            userInfo.IsActive = true; 
            return userInfo;

        }

        public static UserInfo UserInfoDTOToEditEntityMapper(UserInfo userInfo, UserInfoRequestDTO userInfoReq)
        {
            userInfo.UserName = userInfoReq.UserName;
            userInfo.UiUser = userInfoReq.UiUser;
            userInfo.UiPassword = userInfoReq.UiPassword;
            userInfo.UpdatedAt = DateTime.Now;
            return userInfo;
        }

        public static UserInfoResponseDTO EntityToUserInfoDTO(UserInfo userInfo)
        {
            UserInfoResponseDTO userInfoResponseDTO = new UserInfoResponseDTO();
            userInfoResponseDTO.Id = userInfo.Id;
            userInfoResponseDTO.UserName = userInfo.UserName;
            userInfoResponseDTO.UiUser = userInfo.UiUser;
            userInfoResponseDTO.UiPassword = userInfo.UiPassword;
            userInfoResponseDTO.IsActive = userInfo.IsActive;
            userInfoResponseDTO.CreatedAt = DateTime.Now;
            userInfoResponseDTO.UpdatedAt = DateTime.Now;
            userInfoResponseDTO.GlobalId = userInfo.GlobalId;
            return userInfoResponseDTO;
        }

        public static List<UserInfoResponseDTO> EntitiesToUserInfoDTOs(List<UserInfo> userInfos)
        {
            List<UserInfoResponseDTO> userInfoResponseDTOs = new List<UserInfoResponseDTO>();
            foreach (UserInfo userInfo in userInfos)
            {
                UserInfoResponseDTO userInfoResponseDTO = EntityToUserInfoDTO(userInfo);
                userInfoResponseDTOs.Add(userInfoResponseDTO);
            }
            return userInfoResponseDTOs;
        }
    }
}
