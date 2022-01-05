using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class memoriesModel
{
public int? CAPACITY { get; set; }
public string? CAPTION { get; set; }
public string? DESCRIPTION { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public int? NUMSLOTS { get; set; }
public string? PURPOSE { get; set; }
public string? SERIALNUMBER { get; set; }
public string? SPEED { get; set; }
public string? TYPE { get; set; }
public memoriesModel() {}
}
}
