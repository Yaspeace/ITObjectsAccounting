using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class downloadwk_statut_requestModel
{
public int? ACTIF { get; set; }
[Key]
public int ID { get; set; }
public string? LBL { get; set; }
public string? NAME { get; set; }
public downloadwk_statut_requestModel() {}
}
}
