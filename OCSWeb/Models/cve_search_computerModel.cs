using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class cve_search_computerModel
{
public string CVE { get; set; }
public string CVSS { get; set; }
public int HARDWARE_ID { get; set; }
public string HARDWARE_NAME { get; set; }
public string LINK { get; set; }
public string PUBLISHER { get; set; }
public string SOFTWARE_NAME { get; set; }
public string VERSION { get; set; }
public cve_search_computerModel() {}
}
}
