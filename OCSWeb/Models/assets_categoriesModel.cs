using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class assets_categoriesModel
{
public string CATEGORY_DESC { get; set; }
public string CATEGORY_NAME { get; set; }
[Key]
public int ID { get; set; }
public string SQL_ARGS { get; set; }
public string SQL_QUERY { get; set; }
public assets_categoriesModel() {}
}
}
