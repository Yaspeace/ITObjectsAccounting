using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class regconfigModel
{
[Key]
public int ID { get; set; }
public string? NAME { get; set; }
public string? REGKEY { get; set; }
public int? REGTREE { get; set; }
public string? REGVALUE { get; set; }
public regconfigModel() {}
}
}
