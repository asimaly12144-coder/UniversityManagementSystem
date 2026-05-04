using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

public class DegreeProgramServices
{
    private readonly IDegreeProgramRepository _repo;

    public DegreeProgramServices(IDegreeProgramRepository repo)
    {
        _repo = repo;
    }

    public DegreeProgram AddDegreeProgram(DegreeProgramRequestDTO request)
    {
        var entity = DegreeProgramDTOMappers.DegreeProgramDTOToEntityMapper(request);
        entity.CreatedAt = DateTime.Now;
        _repo.Add(entity);
        _repo.Save();
        return entity;
    }

    public List<DegreeProgramResponseDTO> GetAll()
    {
        var entities = _repo.GetAll().ToList();
        return DegreeProgramDTOMappers.EntitiesToDegreeProgramDTOs(entities);
    }

    public bool RemoveDegreeProgram(int? id)
    {
        var entity = _repo.Get(e => e.Id == id);
        _repo.Remove(entity);
        _repo.Save();
        return true;
    }
}
