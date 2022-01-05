using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class save_queryModel
{
public string? DESCRIPTION { get; set; }
[Key]
public int ID { get; set; }
public string PARAMETERS { get; set; }
public string QUERY_NAME { get; set; }
public save_queryModel() {}
}
}
