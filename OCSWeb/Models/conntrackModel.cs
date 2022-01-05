using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class conntrackModel
{
[Key]
public string IP { get; set; }
public DateTime TIMESTAMP { get; set; }
public conntrackModel() {}
}
}
