using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class downloadwk_fieldsModel
{
public int? DEFAULT_FIELD { get; set; }
public string? FIELD { get; set; }
[Key]
public int ID { get; set; }
public string? LBL { get; set; }
public int? LINK_STATUS { get; set; }
public int? MUST_COMPLETED { get; set; }
public int? RESTRICTED { get; set; }
public string? TAB { get; set; }
public int? TYPE { get; set; }
public string? VALUE { get; set; }
public downloadwk_fieldsModel() {}
}
}
