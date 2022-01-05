using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class local_usersModel
{
public string? GID { get; set; }
[Key]
public int HARDWARE_ID { get; set; }
public string? HOME { get; set; }
[Key]
public int ID { get; set; }
public string? ID_USER { get; set; }
public string? LOGIN { get; set; }
public string? MEMBER { get; set; }
public string? NAME { get; set; }
public string? SHELL { get; set; }
public local_usersModel() {}
}
}
