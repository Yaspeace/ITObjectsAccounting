using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class locksModel
{
[Key]
public int HARDWARE_ID { get; set; }
public int? ID { get; set; }
public DateTime SINCE { get; set; }
public locksModel() {}
}
}
