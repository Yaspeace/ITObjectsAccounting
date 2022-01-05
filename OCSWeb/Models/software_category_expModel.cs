using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class software_category_expModel
{
public int CATEGORY_ID { get; set; }
[Key]
public int ID { get; set; }
public string? PUBLISHER { get; set; }
public string? SIGN_VERSION { get; set; }
public string SOFTWARE_EXP { get; set; }
public string? VERSION { get; set; }
public software_category_expModel() {}
}
}
