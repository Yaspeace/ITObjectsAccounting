using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class itmgmt_commentsModel
{
public string? ACTION { get; set; }
public string? COMMENTS { get; set; }
public DateTime? DATE_INSERT { get; set; }
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public string? USER_INSERT { get; set; }
public int? VISIBLE { get; set; }
public itmgmt_commentsModel() {}
}
}
