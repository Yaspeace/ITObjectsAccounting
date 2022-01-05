using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class local_groupsModel
{
[Key]
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? ID_GROUP { get; set; }
public string? MEMBER { get; set; }
public string? NAME { get; set; }
public local_groupsModel() {}
}
}
