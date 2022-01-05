using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class archiveModel
{
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public archiveModel() {}
}
}
