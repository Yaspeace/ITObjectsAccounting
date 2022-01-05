using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class networksModel
{
public string? DESCRIPTION { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? IPADDRESS { get; set; }
public string? IPDHCP { get; set; }
public string? IPGATEWAY { get; set; }
public string? IPMASK { get; set; }
public string? IPSUBNET { get; set; }
public string? MACADDR { get; set; }
public string? MTU { get; set; }
public string? SPEED { get; set; }
public string? STATUS { get; set; }
public string? TYPE { get; set; }
public string? TYPEMIB { get; set; }
public int? VIRTUALDEV { get; set; }
public networksModel() {}
}
}
