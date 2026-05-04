using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class PeoToPloDTOMappers
    {
        // Create PeoToPlo DTO Mapper
        public static PeoToPlo PeoToPloDTOToEntityMapper(PeoToPloRequestDTO dto)
        {
            PeoToPlo peoToPlo = new PeoToPlo();
            peoToPlo.PeoId = dto.PeoId;
            peoToPlo.PloId = dto.PloId;
            peoToPlo.Weightage = dto.Weightage;
            peoToPlo.IsActive = true;
            return peoToPlo;
        }

        // Edit PeoToPlo DTO Mapper
        public static PeoToPlo PeoToPloDTOToEditEntityMapper(PeoToPlo peoToPlo, PeoToPloRequestDTO dto)
        {
            peoToPlo.PeoId = dto.PeoId;
            peoToPlo.PloId = dto.PloId;
            peoToPlo.Weightage = dto.Weightage;
            peoToPlo.UpdatedAt = DateTime.Now;
            return peoToPlo;
        }

        // Entity to Response DTO
        public static PeoToPloResponseDTO EntityToPeoToPloDTO(PeoToPlo peoToPlo)
        {
            PeoToPloResponseDTO dto = new PeoToPloResponseDTO();
            dto.Id = peoToPlo.Id;
            dto.PeoId = peoToPlo.PeoId;
            dto.PloId = peoToPlo.PloId;
            dto.Weightage = peoToPlo.Weightage;

            dto.IsActive = peoToPlo.IsActive;
            dto.GlobalId = peoToPlo.GlobalId;
            dto.CreatedAt = peoToPlo.CreatedAt;
            dto.UpdatedAt = peoToPlo.UpdatedAt;
            dto.DeletedAt = peoToPlo.DeletedAt;
            dto.CreatedBy = peoToPlo.CreatedBy;
            dto.UpdatedBy = peoToPlo.UpdatedBy;
            dto.DeletedBy = peoToPlo.DeletedBy;

            return dto;
        }

        // List of PeoToPloResponseDTO Mapper
        public static List<PeoToPloResponseDTO> EntitiesToPeoToPloDTOs(List<PeoToPlo> peoToPlos)
        {
            List<PeoToPloResponseDTO> responseList = new List<PeoToPloResponseDTO>();
            foreach (PeoToPlo peoToPlo in peoToPlos)
            {
                PeoToPloResponseDTO dto = EntityToPeoToPloDTO(peoToPlo);
                responseList.Add(dto);
            }
            return responseList;
        }
    }
}
