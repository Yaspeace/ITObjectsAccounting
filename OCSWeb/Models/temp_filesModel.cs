using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class temp_filesModel
{
public string? AUTHOR { get; set; }
public string? COMMENT { get; set; }
public string? FIELDS_NAME { get; set; }
public long? file { get; set; }
public string? FILE_NAME { get; set; }
public int? FILE_SIZE { get; set; }
public string? FILE_TYPE { get; set; }
[Key]
public int ID { get; set; }
public int? ID_DDE { get; set; }
public string? TABLE_NAME { get; set; }
public temp_filesModel() {}
}
}
