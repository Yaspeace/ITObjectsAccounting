using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class cve_search_historyModel
{
public int? CVE_NB { get; set; }
public DateTime FLAG_DATE { get; set; }
[Key]
public int ID { get; set; }
public int PUBLISHER_ID { get; set; }
public cve_search_historyModel() {}
}
}
