using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
    public  class PositionSoftBinding
    {
        [Key]
        public int? id { get; set; }
        public int software_id { get; set; }
        public int position_id { get; set; }
        public PositionSoftBinding() { }

        public PositionSoftBinding(int? id, int software_id, int position_id)
        {
            this.id = id;
            this.software_id = software_id;
            this.position_id = position_id;
        }
    }
}
