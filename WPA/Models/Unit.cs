using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
    public class Unit
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string descriprion { get; set; }
        public Unit() { }
    }
}
