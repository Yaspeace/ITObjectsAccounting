using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class software_categoriesModel
{
public string CATEGORY_NAME { get; set; }
[Key]
public int ID { get; set; }
public string? OS { get; set; }
public software_categoriesModel() {}
}
}
