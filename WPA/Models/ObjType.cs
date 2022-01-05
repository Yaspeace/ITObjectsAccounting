using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
    public class ObjType
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public ObjType() { }
    }
}
