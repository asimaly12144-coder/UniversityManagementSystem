using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

public class DepartmentServices
{
    private readonly IDepartmentRepository _repo;

    public DepartmentServices(IDepartmentRepository repo)
    {
        _repo = repo;
    }

    public Department AddDepartment(DepartmentRequestDTO request)
    {
        var entity = DepartmentDTOMappers.DepartmentDTOToEntityMapper(request);
        entity.CreatedAt = DateTime.Now;
        _repo.Add(entity);
        _repo.Save();
        return entity;
    }

    public List<DepartmentResponseDTO> GetAll()
    {
        var entities = _repo.GetAll().ToList();
        return DepartmentDTOMappers.EntitiesToDepartmentDTOs(entities);
    }

    public bool RemoveDepartment(int? id)
    {
        var entity = _repo.Get(e => e.Id == id);
        _repo.Remove(entity);
        _repo.Save();
        return true;
    }
}
