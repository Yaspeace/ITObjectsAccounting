using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
    public class UnitBinding
    {
        [Key]
        public int? id { get; set; }
        public int hardware_id { get; set; }
        public int unit_id { get; set; }
        public UnitBinding() { }
        public UnitBinding(int? id, int hardware_id, int unit_id)
        {
            this.id = id;
            this.hardware_id = hardware_id;
            this.unit_id = unit_id;
        }
    }
}
