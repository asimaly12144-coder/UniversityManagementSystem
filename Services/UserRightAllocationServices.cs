using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;
namespace UniversityManagmentSystem.Services
{
    public class UserRightAllocationServices
    {
        private readonly IUserRightAllocationRepository _userRightAllocationRepository;
        public UserRightAllocationServices(IUserRightAllocationRepository userRightAllocationRepository)
        {
            _userRightAllocationRepository = userRightAllocationRepository;
        }

        public UserRightAllocation AddUserRightAllocation(UserRightAllocationRequestDTO userRightAllocReq)
        {
             UserRightAllocation userRightAllocation=UserRightAllocationDTOMappers.DTOToEntity(userRightAllocReq); 
            _userRightAllocationRepository.Add(userRightAllocation);
            _userRightAllocationRepository.Save();
            return userRightAllocation;
        }

        public List<UseRightAllocationResponseDTO> GetAll()
        {
            List<UserRightAllocation> userRightAllocations = _userRightAllocationRepository.GetAll().ToList();
            return UserRightAllocationDTOMappers.EntitiesToDTOs(userRightAllocations);
        }

        public bool Remove(int? Id)
        {
            UserRightAllocation userRightAllocation = _userRightAllocationRepository.Get(ans => ans.Id == Id);
            _userRightAllocationRepository.Remove(userRightAllocation);
            _userRightAllocationRepository.Save();
            return true;
        }
    }
}
