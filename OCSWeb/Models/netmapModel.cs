using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class netmapModel
{
public DateTime DATE { get; set; }
public string IP { get; set; }
[Key]
public string MAC { get; set; }
public string MASK { get; set; }
public string? NAME { get; set; }
public string NETID { get; set; }
public string? TAG { get; set; }
public netmapModel() {}
}
}
