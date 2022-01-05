using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class operatorsModel
{
public int? ACCESSLVL { get; set; }
public string? COMMENTS { get; set; }
public string? EMAIL { get; set; }
public string? FIRSTNAME { get; set; }
[Key]
public string ID { get; set; }
public string? LASTNAME { get; set; }
public string? NEW_ACCESSLVL { get; set; }
public string? PASSWD { get; set; }
public int? PASSWORD_VERSION { get; set; }
public string? USER_GROUP { get; set; }
public operatorsModel() {}
}
}
