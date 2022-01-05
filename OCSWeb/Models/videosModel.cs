using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class videosModel
{
public string? CHIPSET { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? MEMORY { get; set; }
public string? NAME { get; set; }
public string? RESOLUTION { get; set; }
public videosModel() {}
}
}
