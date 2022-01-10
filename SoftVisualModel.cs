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
        public int? CpuFreq { get; set; }
        public int? CpuCores { get; set; }
        public int? RamMemory { get; set; }
        public int? StorMemory { get; set; }
        public int? WindowsVer { get; set; }
        public int? DirectXVer { get; set; }

        public SoftVisualModel(string name, string path, string? version, int? cpuFreq, int? cpuCores, int? ramMemory, int? storMemory, int? windowsVer, int? directXVer)
        {
            Name = name;
            Path = path;
            Version = version;
            CpuFreq = cpuFreq;
            CpuCores = cpuCores;
            RamMemory = ramMemory;
            StorMemory = storMemory;
            WindowsVer = windowsVer;
            DirectXVer = directXVer;
        }
    }
}
