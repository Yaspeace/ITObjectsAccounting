using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class cve_search_correspondanceModel
{
[Key]
public int ID { get; set; }
public string NAME_REG { get; set; }
public string? NAME_RESULT { get; set; }
public string? PUBLISH_RESULT { get; set; }
public cve_search_correspondanceModel() {}
}
}
