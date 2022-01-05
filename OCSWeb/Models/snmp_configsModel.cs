using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class snmp_configsModel
{
[Key]
public int ID { get; set; }
public int LABEL_ID { get; set; }
public string OID { get; set; }
public string? RECONCILIATION { get; set; }
public int TYPE_ID { get; set; }
public snmp_configsModel() {}
}
}
