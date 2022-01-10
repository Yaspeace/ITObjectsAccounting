using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Kursach_WPF
{
    public class SoftReqVisualModel
    {
        public string? Name { get; set; }
        public int? CPU_Frequency { get; set; }
        public int? CPU_Cores_Num { get; set; }
        public int? RAM_Memoty_MB { get; set; }
        public int? Store_Memory_MB { get; set; }
        public int? OS_Windows_Version { get; set; } //null if not windows
        public int? DirectX_Version { get; set; }
        public SoftReqVisualModel(string? name, int? cPU_Frequency, int? cPU_Cores_Num, int? rAM_Memoty_MB, int? store_Memory_MB, int? oS_Windows_Version, int? directX_Version)
        {
            Name = name;
            CPU_Frequency = cPU_Frequency;
            CPU_Cores_Num = cPU_Cores_Num;
            RAM_Memoty_MB = rAM_Memoty_MB;
            Store_Memory_MB = store_Memory_MB;
            OS_Windows_Version = oS_Windows_Version;
            DirectX_Version = directX_Version;
        }
    }
}
