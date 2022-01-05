using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class biosModel
{
public string? ASSETTAG { get; set; }
public string? BDATE { get; set; }
public string? BMANUFACTURER { get; set; }
public string? BVERSION { get; set; }
[Key]
public int HARDWARE_ID { get; set; }
public string? MMANUFACTURER { get; set; }
public string? MMODEL { get; set; }
public string? MSN { get; set; }
public string? SMANUFACTURER { get; set; }
public string? SMODEL { get; set; }
public string? SSN { get; set; }
public string? TYPE { get; set; }
public biosModel() {}
}
}
