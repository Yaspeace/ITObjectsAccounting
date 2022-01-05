using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class registry_name_cacheModel
{
[Key]
public int ID { get; set; }
public string? NAME { get; set; }
public registry_name_cacheModel() {}
}
}
