using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Services
{
    public class ProgramSessionService
    {
        private readonly IProgramSessionRepository _programSessionRepository;

        public ProgramSessionService(IProgramSessionRepository programSessionRepository)
        {
            _programSessionRepository = programSessionRepository;
        }

        public ProgramSession AddProgramSession(ProgramSessionRequestDTO request)
        {
            ProgramSession programSession = ProgramSessionDTOMappers.ProgramSessionDTOToEntityMappers(request);
            programSession.CreatedAt = DateTime.Now;
            _programSessionRepository.Add(programSession);
            _programSessionRepository.Save();
            return programSession;
        }

        //GetAll
        public List<ProgramSessionResponseDTO> GetAll()
        {
            List<ProgramSession> programSessions = _programSessionRepository.GetAll().ToList();
            return ProgramSessionDTOMappers.EntitiesToProgramSessionDTOs(programSessions);
        }

        //Remove

        public bool RemoveProgramSession(int? Id)
        {
            ProgramSession programSession = _programSessionRepository.Get(ans => ans.Id == Id);
            _programSessionRepository.Remove(programSession);
            _programSessionRepository.Save();
            return true;
        }
    }
}
