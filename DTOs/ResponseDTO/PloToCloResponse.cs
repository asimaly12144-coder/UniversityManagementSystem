using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class PloToCloResponse : BaseResponseDTO
    {
        public int PloId { get; set; }
        public int CloId { get; set; }
        public string Weightage { get; set; }
    }
}
