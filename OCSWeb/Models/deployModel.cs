using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class deployModel
{
public long CONTENT { get; set; }
[Key]
public string NAME { get; set; }
public deployModel() {}
}
}
