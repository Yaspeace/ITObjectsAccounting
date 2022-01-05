using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class snmp_communitiesModel
{
public string? AUTHKEY { get; set; }
public string? AUTHPASSWD { get; set; }
[Key]
public int ID { get; set; }
public string? NAME { get; set; }
public string? USERNAME { get; set; }
public string? VERSION { get; set; }
public snmp_communitiesModel() {}
}
}
