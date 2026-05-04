using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class PeoToPloServices
    {
        private readonly IPeoToPloRepository _peoToPloRepository;

        public PeoToPloServices(IPeoToPloRepository peoToPloRepository)
        {
            _peoToPloRepository = peoToPloRepository;
        }

        public PeoToPlo AddPeoToPlo(PeoToPloRequestDTO request)
        {
            var entity = PeoToPloDTOMappers.PeoToPloDTOToEntityMapper(request);
            entity.CreatedAt = DateTime.Now;
            _peoToPloRepository.Add(entity);
            _peoToPloRepository.Save();
            return entity;
        }

        public List<PeoToPloResponseDTO> GetAll()
        {
            var entities = _peoToPloRepository.GetAll().ToList();
            return PeoToPloDTOMappers.EntitiesToPeoToPloDTOs(entities);
        }

        public bool RemovePeoToPlo(int? id)
        {
            var entity = _peoToPloRepository.Get(e => e.Id == id);
            _peoToPloRepository.Remove(entity);
            _peoToPloRepository.Save();
            return true;
        }
    }

}
