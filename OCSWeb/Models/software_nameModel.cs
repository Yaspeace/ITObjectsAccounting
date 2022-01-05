using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class software_nameModel
{
[Key]
public int ID { get; set; }
public string NAME { get; set; }
public software_nameModel() {}
}
}
