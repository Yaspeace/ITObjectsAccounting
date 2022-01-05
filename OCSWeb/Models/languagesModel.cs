using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class languagesModel
{
public long? IMG { get; set; }
public string? JSON_VALUE { get; set; }
[Key]
public string NAME { get; set; }
public languagesModel() {}
}
}
