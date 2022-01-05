using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class storagesModel
{
public string? DESCRIPTION { get; set; }
public int? DISKSIZE { get; set; }
public string? FIRMWARE { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? MANUFACTURER { get; set; }
public string? MODEL { get; set; }
public string? NAME { get; set; }
public string? SERIALNUMBER { get; set; }
public string? TYPE { get; set; }
public storagesModel() {}
}
}
