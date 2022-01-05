using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class tagsModel
{
[Key]
public string Login { get; set; }
[Key]
public string Tag { get; set; }
public tagsModel() {}
}
}
