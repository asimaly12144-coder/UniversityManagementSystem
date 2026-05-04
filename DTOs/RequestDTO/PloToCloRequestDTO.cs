using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class PloToCloRequestDTO
    {
        public int Id { get; set; }

        public int PloId { get; set; }
        public int CloId { get; set; }
        public string Weightage { get; set; }
    }
}
