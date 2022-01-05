using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class download_enableModel
{
public string? CERT_FILE { get; set; }
public string? CERT_PATH { get; set; }
public string FILEID { get; set; }
public int? GROUP_ID { get; set; }
[Key]
public int ID { get; set; }
public string INFO_LOC { get; set; }
public string PACK_LOC { get; set; }
public int? SERVER_ID { get; set; }
public download_enableModel() {}
}
}
