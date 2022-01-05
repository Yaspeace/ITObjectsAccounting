using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class ssl_storeModel
{
public string? AUTHOR { get; set; }
public string? DESCRIPTION { get; set; }
public long? FILE { get; set; }
public string? FILE_NAME { get; set; }
public string? FILE_TYPE { get; set; }
[Key]
public int ID { get; set; }
public ssl_storeModel() {}
}
}
