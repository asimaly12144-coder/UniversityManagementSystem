namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class PloRequestDTO
    {
        public int Id { get; set; }

        public string PLOName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int DegreeProgramId { get; set; }
    }
}
