using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class dico_softModel
{
[Key]
public string EXTRACTED { get; set; }
public string FORMATTED { get; set; }
public dico_softModel() {}
}
}
