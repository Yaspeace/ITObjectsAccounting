using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class softwareModel
{
public string? ARCHITECTURE { get; set; }
public int? BITSWIDTH { get; set; }
public string? COMMENTS { get; set; }
public string? FILENAME { get; set; }
public int? FILESIZE { get; set; }
public string? FOLDER { get; set; }
public string? GUID { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public long ID { get; set; }
public DateTime? INSTALLDATE { get; set; }
public string? LANGUAGE { get; set; }
public int NAME_ID { get; set; }
public int PUBLISHER_ID { get; set; }
public int? SOURCE { get; set; }
public int VERSION_ID { get; set; }
public softwareModel() {}
}
}
