using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class snmp_mibsModel
{
public string? CHECKSUM { get; set; }
[Key]
public int ID { get; set; }
public string? PARSER { get; set; }
public string? URL { get; set; }
public string? VENDOR { get; set; }
public string? VERSION { get; set; }
public snmp_mibsModel() {}
}
}
