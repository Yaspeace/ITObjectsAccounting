using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class saas_expModel
{
public string DNS_EXP { get; set; }
[Key]
public int ID { get; set; }
public string NAME { get; set; }
public saas_expModel() {}
}
}
