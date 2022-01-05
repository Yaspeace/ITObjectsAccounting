using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class software_linkModel
{
public int? CATEGORY_ID { get; set; }
public int? COUNT { get; set; }
[Key]
public int ID { get; set; }
public string IDENTIFIER { get; set; }
public int NAME_ID { get; set; }
public int PUBLISHER_ID { get; set; }
public int VERSION_ID { get; set; }
public software_linkModel() {}
}
}
