using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class download_availableModel
{
public string? COMMENT { get; set; }
public int? DELETED { get; set; }
[Key]
public string FILEID { get; set; }
public int FRAGMENTS { get; set; }
public int? ID_WK { get; set; }
public string NAME { get; set; }
public string OSNAME { get; set; }
public int PRIORITY { get; set; }
public int SIZE { get; set; }
public download_availableModel() {}
}
}
