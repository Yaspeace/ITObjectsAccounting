using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class network_devicesModel
{
public string? DESCRIPTION { get; set; }
[Key]
public int ID { get; set; }
public string? MACADDR { get; set; }
public string? TYPE { get; set; }
public string? USER { get; set; }
public network_devicesModel() {}
}
}
