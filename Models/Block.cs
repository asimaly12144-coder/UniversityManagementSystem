namespace UniversityManagmentSystem.Models
{
    public class Block : BaseModel
    {
        public string BlockName { get; set; }
        public string BlockCode { get; set; }
        public string BlockDescription { get; set; }
        public string Address { get; set; } //
        public DateTime EstablishedIn { get; set; }
        public int CampusId { get; set; }
        public Campus Campus { get; set; }

        public List<Building> Buildings { get; set; }
    }

}
