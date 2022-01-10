using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
    public  class PositionSoftBinding
    {
        [Key]
        public int? id { get; set; }
        public string soft_name { get; set; }
        public int position_id { get; set; }
        public PositionSoftBinding() { }

        public PositionSoftBinding(int? id, int position_id, string soft_name)
        {
            this.id = id;
            this.soft_name = soft_name;
            this.position_id = position_id;
        }
    }
}
