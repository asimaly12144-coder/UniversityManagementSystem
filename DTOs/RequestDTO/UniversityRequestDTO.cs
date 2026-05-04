namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class UniversityRequestDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string UniversityName { get; set; }
        public string Address { get; set; }

        public DateTime EstablishedIn { get; set; }
       
    }
}
