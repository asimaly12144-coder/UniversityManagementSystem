using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class ProgramSessionDTOMappers
    {
        // To Create ProgramSession Entity from ProgramSessionRequestDTO
        public static ProgramSession ProgramSessionDTOToEntityMappers(ProgramSessionRequestDTO programSessionRequestDTO)
        {
            ProgramSession programSession = new ProgramSession();
            programSession.SessionName = programSessionRequestDTO.SessionName;
            programSession.Code = programSessionRequestDTO.Code;
            programSession.Description = programSessionRequestDTO.Description;
            return programSession;
        }

        // To Edit ProgramSession Entity from ProgramSessionRequestDTO

        public static ProgramSession ProgramSessionDTOToEditEntityMappers(ProgramSession programSession, ProgramSessionRequestDTO programSessionRequestDTO)
        {
            programSession.SessionName = programSessionRequestDTO.SessionName;
            programSession.Code = programSessionRequestDTO.Code;
            programSession.Description = programSessionRequestDTO.Description;
            programSession.UpdatedAt = DateTime.Now;
            return programSession;
        }

        //Reponse

        public static ProgramSessionResponseDTO ProgramSessionEntityToDTO(ProgramSession programSession)
        {
            ProgramSessionResponseDTO programSessionResponseDTO = new ProgramSessionResponseDTO();
            programSessionResponseDTO.Id = programSession.Id;
            programSessionResponseDTO.SessionName = programSession.SessionName;
            programSessionResponseDTO.Code = programSession.Code;
            programSessionResponseDTO.Description = programSession.Description;
            programSessionResponseDTO.CreatedAt = programSession.CreatedAt;
            programSessionResponseDTO.UpdatedAt = programSession.UpdatedAt;
            programSessionResponseDTO.DeletedAt = programSession.DeletedAt;
            programSessionResponseDTO.CreatedBy= programSession.CreatedBy;
            programSessionResponseDTO.UpdatedBy = programSession.UpdatedBy;
            programSessionResponseDTO.DeletedBy = programSession.DeletedBy;
            programSessionResponseDTO.IsActive = programSession.IsActive;
            return programSessionResponseDTO;
        }

        // List of ProgramSessionResponseDTO Mapper

        public static List<ProgramSessionResponseDTO> EntitiesToProgramSessionDTOs(List<ProgramSession> programSessions)
        {
            List<ProgramSessionResponseDTO> responseDTOs = new List<ProgramSessionResponseDTO>();
            foreach (ProgramSession session in programSessions)
            {
                ProgramSessionResponseDTO responseDTO = ProgramSessionEntityToDTO(session);
                responseDTOs.Add(ProgramSessionEntityToDTO(session));
            }
            return responseDTOs;
        }

    }
}
