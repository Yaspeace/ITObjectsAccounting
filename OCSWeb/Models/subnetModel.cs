using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class subnetModel
{
public string? ID { get; set; }
public string? MASK { get; set; }
public string? NAME { get; set; }
public string NETID { get; set; }
public string? TAG { get; set; }
public subnetModel() {}
}
}
