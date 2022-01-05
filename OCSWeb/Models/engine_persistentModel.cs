using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class engine_persistentModel
{
public int ID { get; set; }
public int? IVALUE { get; set; }
[Key]
public string NAME { get; set; }
public string? TVALUE { get; set; }
public engine_persistentModel() {}
}
}
