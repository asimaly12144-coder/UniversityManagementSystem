using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

public class CloToSubjectServices
{
    private readonly ICloToSubjectRepository _repository;

    public CloToSubjectServices(ICloToSubjectRepository repository)
    {
        _repository = repository;
    }

    public CloToSubject Add(CloToSubjectRequestDTO request)
    {
        var entity = CloToSubjectDTOMappers.CloToSubjectDTOToEntityMapper(request);
        entity.CreatedAt = DateTime.Now;
        _repository.Add(entity);
        _repository.Save();
        return entity;
    }

    public List<CloToSubjectResponseDTO> GetAll()
    {
        var list = _repository.GetAll().ToList();
        return CloToSubjectDTOMappers.EntitiesToCloToSubjectDTOs(list);
    }

    public bool Remove(int? id)
    {
        var entity = _repository.Get(x => x.Id == id);
        _repository.Remove(entity);
        _repository.Save();
        return true;
    }
}
