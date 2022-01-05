using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class javainfoModel
{
[Key]
public int HARDWARE_ID { get; set; }
public string? JAVACLASSPATH { get; set; }
public string? JAVACOUNTRY { get; set; }
public string? JAVAHOME { get; set; }
public string? JAVANAME { get; set; }
public int? JAVAPATHLEVEL { get; set; }
public javainfoModel() {}
}
}
