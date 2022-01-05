using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class downloadwk_conf_valuesModel
{
public int? DEFAULT_FIELD { get; set; }
public int? FIELD { get; set; }
[Key]
public int ID { get; set; }
public string? VALUE { get; set; }
public downloadwk_conf_valuesModel() {}
}
}
