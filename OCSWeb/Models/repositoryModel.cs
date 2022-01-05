using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class repositoryModel
{
public string? BASEURL { get; set; }
public string? EXCLUDE { get; set; }
public string? EXCLUDED { get; set; }
public string? EXPIRE { get; set; }
public string? FILENAME { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? MIRRORS { get; set; }
public string? NAME { get; set; }
public string? PKGS { get; set; }
public string? REVISION { get; set; }
public string? SIZE { get; set; }
public string? TAG { get; set; }
public string? UPDATED { get; set; }
public repositoryModel() {}
}
}
