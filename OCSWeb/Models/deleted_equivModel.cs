using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class deleted_equivModel
{
public DateTime DATE { get; set; }
public string DELETED { get; set; }
public string? EQUIVALENT { get; set; }
[Key]
public int ID { get; set; }
public deleted_equivModel() {}
}
}
