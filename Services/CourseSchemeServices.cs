using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

public class CourseSchemeServices
{
    private readonly ICourseSchemeRepository _repo;

    public CourseSchemeServices(ICourseSchemeRepository repo)
    {
        _repo = repo;
    }

    public CourseScheme Add(CourseSchemeRequestDTO request)
    {
        var entity = CourseSchemeDTOMappers.CourseSchemeDTOToEntityMapper(request);
        entity.CreatedAt = DateTime.Now;
        _repo.Add(entity);
        _repo.Save();
        return entity;
    }

    public List<CourseSchemeResponseDTO> GetAll()
    {
        var list = _repo.GetAll().ToList();
        return CourseSchemeDTOMappers.EntitiesToCourseSchemeDTOs(list);
    }

    public bool Remove(int? id)
    {
        var entity = _repo.Get(x => x.Id == id);
        _repo.Remove(entity);
        _repo.Save();
        return true;
    }
}
