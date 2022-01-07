using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Kursach_WPF
{
    public class SoftVisualModel
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string? Version { get; set; }

        public SoftVisualModel(string name, string path, string? version)
        {
            Name = name;
            Path = path;
            Version = version;
        }
    }
}
