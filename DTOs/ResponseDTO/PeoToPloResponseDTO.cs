using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class PeoToPloResponseDTO : BaseResponseDTO
    {
        public int PeoId { get; set; }
        public int PloId { get; set; }
        public string Weightage { get; set; }
    }
}
