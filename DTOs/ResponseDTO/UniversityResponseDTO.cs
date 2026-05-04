namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    //Create to DTO
    public class UniversityResponseDTO : BaseResponseDTO
    {
        public string Description { get; set; }
        public string UniversityName { get; set; }
        public string Address { get; set; }
        public DateTime EstablishedIn { get; set; }
    }
   
}
