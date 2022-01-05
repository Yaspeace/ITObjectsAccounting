using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class extensionsModel
{
public string? author { get; set; }
public string? contributor { get; set; }
public string? description { get; set; }
public string id { get; set; }
public DateTime install_date { get; set; }
public string? licence { get; set; }
public string name { get; set; }
public double version { get; set; }
public extensionsModel() {}
}
}
