using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class drivesModel
{
public DateTime? CREATEDATE { get; set; }
public string? FILESYSTEM { get; set; }
public int? FREE { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? LETTER { get; set; }
public int? NUMFILES { get; set; }
public int? TOTAL { get; set; }
public string? TYPE { get; set; }
public string? VOLUMN { get; set; }
public drivesModel() {}
}
}
