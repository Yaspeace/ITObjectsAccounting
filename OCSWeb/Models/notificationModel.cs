using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class notificationModel
{
public string? ALTBODY { get; set; }
public string? FILE { get; set; }
[Key]
public int ID { get; set; }
public string? SUBJECT { get; set; }
public string TYPE { get; set; }
public notificationModel() {}
}
}
