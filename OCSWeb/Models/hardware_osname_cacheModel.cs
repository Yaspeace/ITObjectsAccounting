using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class hardware_osname_cacheModel
{
[Key]
public int ID { get; set; }
public string? OSNAME { get; set; }
public hardware_osname_cacheModel() {}
}
}
