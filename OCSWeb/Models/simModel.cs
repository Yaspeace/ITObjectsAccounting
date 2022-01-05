using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class simModel
{
public string? COUNTRY { get; set; }
public string? DEVICEID { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? OPERATOR { get; set; }
public string? OPNAME { get; set; }
public string? PHONENUMBER { get; set; }
public string? SERIALNUMBER { get; set; }
public simModel() {}
}
}
