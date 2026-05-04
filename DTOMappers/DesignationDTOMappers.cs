using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class DesignationDTOMappers
    {
        // To Create Designation Entity from DesignationRequestDTO
        public static Designation DesignationDTOToEntityMappers(DesignationRequestDTO designationRequestDTO)
        {
            Designation designation = new Designation();
            designation.DesignationName = designationRequestDTO.DesignationName;
            designation.Description = designationRequestDTO.Description;
            designation.Code = designationRequestDTO.Code;
            return designation;

        }

        // To Edit Designation Entity from DesignationRequestDTO

        public static Designation DesignationDTOToEntityMappers(Designation designation, DesignationRequestDTO designationRequestDTO)
        {
            designation.DesignationName = designationRequestDTO.DesignationName;
            designation.Description = designationRequestDTO.Description;
            designation.Code = designationRequestDTO.Code;
            designation.UpdatedAt = DateTime.Now;
            return designation;
        }

        // Response DTO Mapper

        public static DesignationResponseDTO EntityToDesignationDTO(Designation designation)
        {
            DesignationResponseDTO designationResponseDTO = new DesignationResponseDTO();
            designationResponseDTO.Id = designation.Id;
            designationResponseDTO.DesignationName = designation.DesignationName;
            designationResponseDTO.Description = designation.Description;
            designationResponseDTO.Code = designation.Code;
            designationResponseDTO.CreatedAt = DateTime.Now;
            designationResponseDTO.UpdatedAt = DateTime.Now;
            designationResponseDTO.GlobalId = designation.GlobalId;
            return designationResponseDTO;
        }

        // List of DesignationResponseDTO Mapper

        public static List<DesignationResponseDTO> EntitiesToDesignationDTOs(List<Designation> designations)
        {
            List<DesignationResponseDTO> designationResponseDTOs = new List<DesignationResponseDTO>();
            foreach (Designation designation in designations)
            {
                DesignationResponseDTO designationResponseDTO = EntityToDesignationDTO(designation);
                designationResponseDTOs.Add(designationResponseDTO);
            }
            return designationResponseDTOs;
        }


    }
}
