using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
    public class SoftwareReq
    {
        [Key]
        public int id { get; set; }
        public int software_id { get; set; }
        public int cpu_freq { get; set; }
        public int cpu_cores { get; set; }
        public int ram_memory_mb { get; set; }
        public int hard_drive_mem_amount_mb { get; set; }
        public int? os_windows_version { get; set; } //null if not windows
        public int? directx_version { get; set; }
        public SoftwareReq() { }
        public SoftwareReq(int id, int software_id, int cpu_freq, int cpu_cores, int ram_memory_mb, int hard_drive_mem_amount_mb, int? os_windows_version, int? directx_version)
        {
            this.id = id;
            this.software_id = software_id;
            this.cpu_freq = cpu_freq;
            this.cpu_cores = cpu_cores;
            this.ram_memory_mb = ram_memory_mb;
            this.hard_drive_mem_amount_mb = hard_drive_mem_amount_mb;
            this.os_windows_version = os_windows_version;
            this.directx_version = directx_version;
        }
    }
}
