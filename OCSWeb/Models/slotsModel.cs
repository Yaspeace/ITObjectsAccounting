using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class slotsModel
{
public string? DESCRIPTION { get; set; }
public string? DESIGNATION { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? NAME { get; set; }
public int? PSHARE { get; set; }
public string? PURPOSE { get; set; }
public string? STATUS { get; set; }
public slotsModel() {}
}
}
