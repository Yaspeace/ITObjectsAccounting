using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class configModel
{
public string? COMMENTS { get; set; }
public int? IVALUE { get; set; }
[Key]
public string NAME { get; set; }
public string? TVALUE { get; set; }
public configModel() {}
}
}
