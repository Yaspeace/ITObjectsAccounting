using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class filesModel
{
public long CONTENT { get; set; }
[Key]
public string NAME { get; set; }
[Key]
public string OS { get; set; }
[Key]
public string VERSION { get; set; }
public filesModel() {}
}
}
