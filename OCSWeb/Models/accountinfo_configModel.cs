using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class accountinfo_configModel
{
public string? ACCOUNT_TYPE { get; set; }
public string? COMMENT { get; set; }
public string? DEFAULT_VALUE { get; set; }
[Key]
public int ID { get; set; }
public int? ID_TAB { get; set; }
public string? NAME { get; set; }
public string? NAME_ACCOUNTINFO { get; set; }
public int SHOW_ORDER { get; set; }
public int? TYPE { get; set; }
public accountinfo_configModel() {}
}
}
