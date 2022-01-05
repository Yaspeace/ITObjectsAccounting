using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class software_versionModel
{
[Key]
public int ID { get; set; }
public string VERSION { get; set; }
public software_versionModel() {}
}
}
