using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class notification_configModel
{
[Key]
public int ID { get; set; }
public string NAME { get; set; }
public string? TVALUE { get; set; }
public notification_configModel() {}
}
}
