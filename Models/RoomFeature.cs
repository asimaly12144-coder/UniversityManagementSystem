using System.ComponentModel.DataAnnotations;

namespace UniversityManagmentSystem.Models
{
    public class RoomFeature : BaseModel
    {
       
        public string RoomFeatureName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public List<RoomFeatureAllocation> RoomFeatureAllocations { get; set; }


    }

}
