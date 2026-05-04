namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class BaseResponseDTO
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public Guid GlobalId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public int DeletedBy { get; set; }
    }
}
