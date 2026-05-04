using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class DepartmentDTOMappers
    {
        // Create Department DTO Mapper
        public static Department DepartmentDTOToEntityMapper(DepartmentRequestDTO dto)
        {
            Department department = new Department();
            department.DepartmentName = dto.DepartmentName;
            department.Description = dto.Description;
            department.Code = dto.Code;
            department.InstituteId = dto.InstituteId;
            department.IsActive = true;
            return department;
        }

        // Edit Department DTO Mapper
        public static Department DepartmentDTOToEditEntityMapper(Department department, DepartmentRequestDTO dto)
        {
            department.DepartmentName = dto.DepartmentName;
            department.Description = dto.Description;
            department.Code = dto.Code;
            department.InstituteId = dto.InstituteId;
            department.UpdatedAt = DateTime.Now;
            return department;
        }

        // Entity to Response DTO
        public static DepartmentResponseDTO EntityToDepartmentDTO(Department department)
        {
            DepartmentResponseDTO dto = new DepartmentResponseDTO();
            dto.Id = department.Id;
            dto.DepartmentName = department.DepartmentName;
            dto.Description = department.Description;
            dto.Code = department.Code;
            dto.InstituteId = department.InstituteId;

            dto.IsActive = department.IsActive;
            dto.GlobalId = department.GlobalId;
            dto.CreatedAt = department.CreatedAt;
            dto.UpdatedAt = department.UpdatedAt;
            dto.DeletedAt = department.DeletedAt;
            dto.CreatedBy = department.CreatedBy;
            dto.UpdatedBy = department.UpdatedBy;
            dto.DeletedBy = department.DeletedBy;

            return dto;
        }

        // List of DepartmentResponseDTO Mapper
        public static List<DepartmentResponseDTO> EntitiesToDepartmentDTOs(List<Department> departments)
        {
            List<DepartmentResponseDTO> responseList = new List<DepartmentResponseDTO>();
            foreach (Department department in departments)
            {
                DepartmentResponseDTO dto = EntityToDepartmentDTO(department);
                responseList.Add(dto);
            }
            return responseList;
        }
    }
}
