using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;
namespace UniversityManagmentSystem.Services
{
    public class UserTypeAllocationServices
    {
        private readonly IUserTypeAllocationRepository _userTypeAllocationRepository;
        public UserTypeAllocationServices(IUserTypeAllocationRepository userTypeAllocationRepository)
        {
            _userTypeAllocationRepository = userTypeAllocationRepository;
        }
        public UserTypeAllocation AddUserTypeAllocation(UserTypeAllocationRequestDTO request)
        {
            UserTypeAllocation userTypeAllocation = UserTypeAllocationDTOMappers.DTOToEntity(request);
            _userTypeAllocationRepository.Add(userTypeAllocation);
            _userTypeAllocationRepository.Save();
            return userTypeAllocation;

        }
        public List<UserTypeAllocationResponseDTO> GetAll()
        {
            List<UserTypeAllocation> userTypeAllocations = _userTypeAllocationRepository.GetAll().ToList();
            return UserTypeAllocationDTOMappers.EntitiesToDTOs(userTypeAllocations);
        }
        public bool Remove(int? Id)
        {
            UserTypeAllocation userTypeAllocation = _userTypeAllocationRepository.Get(ans => ans.Id == Id);
            _userTypeAllocationRepository.Remove(userTypeAllocation);
            _userTypeAllocationRepository.Save();
            return true;
        }

    }
}
