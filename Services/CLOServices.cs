using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

public class CLOServices
{
    private readonly ICLORepository _cloRepository;

    public CLOServices(ICLORepository cloRepository)
    {
        _cloRepository = cloRepository;
    }

    public CourseLearningOutcomes AddCLO(CLORequesDTO request)
    {
        CourseLearningOutcomes clo = CLODTOMappers.CloDTOToEntityMapper(request);
        clo.CreatedAt = DateTime.Now;
        _cloRepository.Add(clo);
        _cloRepository.Save();
        return clo;
    }

    public List<CloResponseDTO> GetAll()
    {
        var clos = _cloRepository.GetAll().ToList();
        return CLODTOMappers.EntitiesToCloDTOs(clos);
    }

    public bool RemoveCLO(int? id)
    {
        var clo = _cloRepository.Get(c => c.Id == id);
        _cloRepository.Remove(clo);
        _cloRepository.Save();
        return true;
    }
}
