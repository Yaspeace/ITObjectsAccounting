using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class download_serversModel
{
public int ADD_PORT { get; set; }
public string ADD_REP { get; set; }
public int GROUP_ID { get; set; }
[Key]
public int HARDWARE_ID { get; set; }
public string URL { get; set; }
public download_serversModel() {}
}
}
