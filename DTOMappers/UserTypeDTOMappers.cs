using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class UserTypeDTOMappers
    {
        public static UserType UserTypeDTOToEntityMapper(UserTypeRequestDTO userTypeReq)
        {
            UserType userType = new UserType();
            userType.Id = userTypeReq.Id;
            userType.UserTypeCode = userTypeReq.UserTypeCode;
            userType.UserTypeName = userTypeReq.UserTypeName;
            userType.IsActive = true;
            return userType;
        }
        public static UserType UserTypeDTOToEditEntityMapper(UserType userType, UserTypeRequestDTO userTypeReq)
        {
            userType.UserTypeCode = userTypeReq.UserTypeCode;
            userType.UserTypeName = userTypeReq.UserTypeName;
            userType.UpdatedAt = DateTime.Now;
            return userType;
        }
        public static UserTypeResponseDTO EntityToUserTypeDTO(UserType userType)
        {
            UserTypeResponseDTO userTypeResponseDTO = new UserTypeResponseDTO();
            userTypeResponseDTO.Id = userType.Id;
            userTypeResponseDTO.UserTypeCode = userType.UserTypeCode;
            userTypeResponseDTO.UserTypeName = userType.UserTypeName;
            userTypeResponseDTO.IsActive = userType.IsActive;
            userTypeResponseDTO.CreatedAt = DateTime.Now;
            userTypeResponseDTO.UpdatedAt = DateTime.Now;
            userTypeResponseDTO.GlobalId = userType.GlobalId;
            return userTypeResponseDTO;
        }
        public static List<UserTypeResponseDTO> EntitiesToUserTypeDTOs(List<UserType> userTypes)
        {
            List<UserTypeResponseDTO> userTypeResponseDTOs = new List<UserTypeResponseDTO>();
            foreach (UserType userType in userTypes)
            {
                UserTypeResponseDTO userTypeResponseDTO = EntityToUserTypeDTO(userType);
                userTypeResponseDTOs.Add(userTypeResponseDTO);
            }
            return userTypeResponseDTOs;
        }
    }
}
