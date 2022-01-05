using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class blacklist_serialsModel
{
[Key]
public int ID { get; set; }
public string SERIAL { get; set; }
public blacklist_serialsModel() {}
}
}
