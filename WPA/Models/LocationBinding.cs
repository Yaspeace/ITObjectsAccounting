using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
    public class LocationBinding
    {
        [Key]
        public int? id { get; set; }
        public int hardware_id { get; set; }
        public int location_id { get; set; }
        public LocationBinding() { }
        public LocationBinding(int? id, int hardware_id, int location_id)
        {
            this.id = id;
            this.hardware_id = hardware_id;
            this.location_id = location_id;
        }
    }
}
