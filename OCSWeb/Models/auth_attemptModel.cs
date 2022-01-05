using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class auth_attemptModel
{
public DateTime DATETIMEATTEMPT { get; set; }
[Key]
public int ID { get; set; }
public string? IP { get; set; }
public string? LOGIN { get; set; }
public int? SUCCESS { get; set; }
public auth_attemptModel() {}
}
}
