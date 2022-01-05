using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class snmp_labelsModel
{
[Key]
public int ID { get; set; }
public string LABEL_NAME { get; set; }
public snmp_labelsModel() {}
}
}
