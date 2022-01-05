using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class groupsModel
{
public int? CREATE_TIME { get; set; }
[Key]
public int HARDWARE_ID { get; set; }
public string? REQUEST { get; set; }
public int? REVALIDATE_FROM { get; set; }
public string? XMLDEF { get; set; }
public groupsModel() {}
}
}
