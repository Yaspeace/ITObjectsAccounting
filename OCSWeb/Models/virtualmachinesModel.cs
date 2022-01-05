using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class virtualmachinesModel
{
public int HARDWARE_ID { get; set; }
[Key]
public int ID { get; set; }
public int? MEMORY { get; set; }
public string? NAME { get; set; }
public string? STATUS { get; set; }
public string? SUBSYSTEM { get; set; }
public string? UUID { get; set; }
public int? VCPU { get; set; }
public string? VMTYPE { get; set; }
public virtualmachinesModel() {}
}
}
