using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

public class FacultyCampusServices
{
    private readonly IFacultyCampusRepository _repo;

    public FacultyCampusServices(IFacultyCampusRepository repo)
    {
        _repo = repo;
    }

    public FacultyCampus AddFacultyCampus(FacultyCampusRequestDTO request)
    {
        var entity = FacultyCampusDTOMappers.FacultyCampusDTOToEntityMapper(request);
        entity.CreatedAt = DateTime.Now;
        _repo.Add(entity);
        _repo.Save();
        return entity;
    }

    public List<FacultyCampusResponseDTO> GetAll()
    {
        var entities = _repo.GetAll().ToList();
        return FacultyCampusDTOMappers.EntitiesToFacultyCampusDTOs(entities);
    }

    public bool RemoveFacultyCampus(int? id)
    {
        var entity = _repo.Get(e => e.Id == id);
        _repo.Remove(entity);
        _repo.Save();
        return true;
    }
}
