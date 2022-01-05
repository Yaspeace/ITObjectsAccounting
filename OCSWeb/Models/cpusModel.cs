using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class cpusModel
{
public int? CORES { get; set; }
public string? CPUARCH { get; set; }
public int? CURRENT_ADDRESS_WIDTH { get; set; }
public string? CURRENT_SPEED { get; set; }
public int? DATA_WIDTH { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? L2CACHESIZE { get; set; }
public int? LOGICAL_CPUS { get; set; }
public string? MANUFACTURER { get; set; }
public string? SERIALNUMBER { get; set; }
public string? SOCKET { get; set; }
public string? SPEED { get; set; }
public string? TYPE { get; set; }
public string? VOLTAGE { get; set; }
public cpusModel() {}
}
}
