using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class groups_cacheModel
{
[Key]
public int GROUP_ID { get; set; }
[Key]
public int HARDWARE_ID { get; set; }
public int? STATIC { get; set; }
public groups_cacheModel() {}
}
}
