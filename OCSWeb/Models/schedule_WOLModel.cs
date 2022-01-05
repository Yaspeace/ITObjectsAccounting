using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class schedule_WOLModel
{
[Key]
public int ID { get; set; }
public string MACHINE_ID { get; set; }
public DateTime WOL_DATE { get; set; }
public schedule_WOLModel() {}
}
}
