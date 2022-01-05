using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class accountinfoModel
{
[Key]
public int HARDWARE_ID { get; set; }
public string? TAG { get; set; }
public accountinfoModel() {}
}
}
