using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
    public class Location
    {
        [Key]
        public int? id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Location() { }

        public Location(int? id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }
}
