using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
    public class PositionObjBinding
    {
        [Key]
        public int? id { get; set; }
        public int hardware_id { get; set; }
        public int position_id { get; set; }
        public PositionObjBinding() { }
        public PositionObjBinding(int? id, int hardware_id, int position_id)
        {
            this.id = id;
            this.hardware_id = hardware_id;
            this.position_id = position_id;
        }
    }
}
