using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class cve_searchModel
{
public string? CVE { get; set; }
public double CVSS { get; set; }
public string? LINK { get; set; }
public int NAME_ID { get; set; }
public int PUBLISHER_ID { get; set; }
public int VERSION_ID { get; set; }
public cve_searchModel() {}
}
}
