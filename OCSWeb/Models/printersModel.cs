using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class printersModel
{
public string? COMMENT { get; set; }
public string? DESCRIPTION { get; set; }
public string? DRIVER { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? NAME { get; set; }
public int? NETWORK { get; set; }
public string? PORT { get; set; }
public string? RESOLUTION { get; set; }
public string? SERVERNAME { get; set; }
public int? SHARED { get; set; }
public string? SHARENAME { get; set; }
public printersModel() {}
}
}
