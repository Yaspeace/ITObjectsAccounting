using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class accesslogModel
{
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public DateTime? LOGDATE { get; set; }
public string? PROCESSES { get; set; }
public string? USERID { get; set; }
public accesslogModel() {}
}
}
