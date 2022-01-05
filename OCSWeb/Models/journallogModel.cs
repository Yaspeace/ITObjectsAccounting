using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class journallogModel
{
public string? DATE { get; set; }
public int? ERRORCODE { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? JOURNALLOG { get; set; }
public string? LISTENERNAME { get; set; }
public int? STATUS { get; set; }
public journallogModel() {}
}
}
