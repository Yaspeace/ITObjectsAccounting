using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class monitorsModel
{
public string? CAPTION { get; set; }
public string? DESCRIPTION { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? MANUFACTURER { get; set; }
public string? SERIAL { get; set; }
public string? TYPE { get; set; }
public monitorsModel() {}
}
}
