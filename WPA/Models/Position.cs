using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Kursach_WPF
{
    public class Position
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string descriprion { get; set; }
        public Position() { }
    }
}
