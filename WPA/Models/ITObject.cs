using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
    public class ITObject
    {
        [Key]
        public int id { get; set; }
        public int obj_type_id { get; set; }
        public int location_id { get; set; }
        public int unit_id { get; set; }
        public int position_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public ITObject() { }
    }
}
