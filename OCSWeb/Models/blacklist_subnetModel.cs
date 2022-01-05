using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class blacklist_subnetModel
{
[Key]
public int ID { get; set; }
public string MASK { get; set; }
public string SUBNET { get; set; }
public blacklist_subnetModel() {}
}
}
