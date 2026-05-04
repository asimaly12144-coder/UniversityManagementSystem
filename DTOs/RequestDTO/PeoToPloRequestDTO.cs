using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class PeoToPloRequestDTO
    {
        public int Id { get; set; }

        public int PeoId { get; set; }
        public int PloId { get; set; }
        public string Weightage { get; set; }
    }
}
