using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class snmp_typesModel
{
public string CONDITION_OID { get; set; }
public string CONDITION_VALUE { get; set; }
[Key]
public int ID { get; set; }
public string TABLE_TYPE_NAME { get; set; }
public string TYPE_NAME { get; set; }
public snmp_typesModel() {}
}
}
