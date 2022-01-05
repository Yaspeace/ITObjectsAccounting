using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class download_historyModel
{
public int HARDWARE_ID { get; set; }
public int PKG_ID { get; set; }
public string? PKG_NAME { get; set; }
public download_historyModel() {}
}
}
