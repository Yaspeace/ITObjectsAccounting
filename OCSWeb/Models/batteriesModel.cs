using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class batteriesModel
{
public string? CHEMISTRY { get; set; }
public string? DESIGNCAPACITY { get; set; }
public string? DESIGNVOLTAGE { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? LOCATION { get; set; }
public string? MANUFACTUREDATE { get; set; }
public string? MANUFACTURER { get; set; }
public int? MAXERROR { get; set; }
public string? NAME { get; set; }
public string? OEMSPECIFIC { get; set; }
public string? SBDSVERSION { get; set; }
public string? SERIALNUMBER { get; set; }
public batteriesModel() {}
}
}
