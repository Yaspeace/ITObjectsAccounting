using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class downloadwk_historyModel
{
public string? ACTION { get; set; }
public string? AUTHOR { get; set; }
public DateTime? DATE { get; set; }
[Key]
public int ID { get; set; }
public int? ID_DDE { get; set; }
public downloadwk_historyModel() {}
}
}
