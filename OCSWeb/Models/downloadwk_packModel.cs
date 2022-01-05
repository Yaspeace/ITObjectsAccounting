using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class downloadwk_packModel
{
public string? fields_1 { get; set; }
public string? fields_10 { get; set; }
public string? fields_2 { get; set; }
public string? fields_3 { get; set; }
public string? fields_4 { get; set; }
public string? fields_5 { get; set; }
public string? fields_6 { get; set; }
public string? fields_7 { get; set; }
public string? fields_8 { get; set; }
public string? fields_9 { get; set; }
public string? GROUP_USER { get; set; }
[Key]
public int ID { get; set; }
public string? LOGIN_USER { get; set; }
public int? Q_DATE { get; set; }
public downloadwk_packModel() {}
}
}
