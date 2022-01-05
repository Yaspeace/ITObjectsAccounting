using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class blacklist_macaddressesModel
{
[Key]
public int ID { get; set; }
public string MACADDRESS { get; set; }
public blacklist_macaddressesModel() {}
}
}
