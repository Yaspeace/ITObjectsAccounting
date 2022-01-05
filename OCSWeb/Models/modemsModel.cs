using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class modemsModel
{
public string? DESCRIPTION { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? MODEL { get; set; }
public string? NAME { get; set; }
public string? TYPE { get; set; }
public modemsModel() {}
}
}
