using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class prolog_conntrackModel
{
public string? DEVICEID { get; set; }
[Key]
public int ID { get; set; }
public int? PID { get; set; }
public int? TIMESTAMP { get; set; }
public prolog_conntrackModel() {}
}
}
