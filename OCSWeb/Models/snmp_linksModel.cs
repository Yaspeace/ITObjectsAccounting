using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class snmp_linksModel
{
public int ACCOUNT_ID { get; set; }
public int DEVICE_ID { get; set; }
[Key]
public int ID { get; set; }
public int TYPE_ID { get; set; }
public snmp_linksModel() {}
}
}
