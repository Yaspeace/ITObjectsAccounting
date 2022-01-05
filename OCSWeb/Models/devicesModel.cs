using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class devicesModel
{
public string? COMMENTS { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public int? IVALUE { get; set; }
public string NAME { get; set; }
public string? TVALUE { get; set; }
public devicesModel() {}
}
}
