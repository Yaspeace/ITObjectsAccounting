using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class registryModel
{
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? NAME { get; set; }
public string? REGVALUE { get; set; }
public registryModel() {}
}
}
