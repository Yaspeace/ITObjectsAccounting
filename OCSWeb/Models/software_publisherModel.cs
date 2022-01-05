using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class software_publisherModel
{
[Key]
public int ID { get; set; }
public string PUBLISHER { get; set; }
public software_publisherModel() {}
}
}
