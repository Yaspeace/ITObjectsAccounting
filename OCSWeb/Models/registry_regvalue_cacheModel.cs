using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class registry_regvalue_cacheModel
{
[Key]
public int ID { get; set; }
public string? REGVALUE { get; set; }
public registry_regvalue_cacheModel() {}
}
}
