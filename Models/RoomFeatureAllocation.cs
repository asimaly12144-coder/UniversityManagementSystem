using Microsoft.AspNetCore.Http.Features;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagmentSystem.Models
{
    public class RoomFeatureAllocation : BaseModel
    {
        
       
        public int RoomFeatureId { get; set; }
        public RoomFeature RoomFeature { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }

        public int Quantity { get; set; }
    }

}
