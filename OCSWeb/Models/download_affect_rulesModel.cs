using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class download_affect_rulesModel
{
public string CFIELD { get; set; }
public string COMPTO { get; set; }
[Key]
public int ID { get; set; }
public string OP { get; set; }
public int PRIORITY { get; set; }
public int RULE { get; set; }
public string RULE_NAME { get; set; }
public string? SERV_VALUE { get; set; }
public download_affect_rulesModel() {}
}
}
