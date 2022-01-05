using System;
using System.ComponentModel.DataAnnotations;

namespace BD_Kursach_WPF
{
public class hardwareModel
{
public string? ARCH { get; set; }
public int? ARCHIVE { get; set; }
public int? CATEGORY_ID { get; set; }
public long? CHECKSUM { get; set; }
public string? DEFAULTGATEWAY { get; set; }
public string? DESCRIPTION { get; set; }
public string DEVICEID { get; set; }
public string? DNS { get; set; }
public DateTime? ETIME { get; set; }
public long? FIDELITY { get; set; }
[Key]
public int ID { get; set; }
public string? IPADDR { get; set; }
public string? IPSRC { get; set; }
public DateTime? LASTCOME { get; set; }
public DateTime? LASTDATE { get; set; }
public int? MEMORY { get; set; }
public string? NAME { get; set; }
public string? OSCOMMENTS { get; set; }
public string? OSNAME { get; set; }
public string? OSVERSION { get; set; }
public int? PROCESSORN { get; set; }
public int? PROCESSORS { get; set; }
public string? PROCESSORT { get; set; }
public decimal? QUALITY { get; set; }
public int? SSTATE { get; set; }
public int? SWAP { get; set; }
public int? TYPE { get; set; }
public string? USERAGENT { get; set; }
public string? USERDOMAIN { get; set; }
public string? USERID { get; set; }
public string? UUID { get; set; }
public string? WINCOMPANY { get; set; }
public string? WINOWNER { get; set; }
public string? WINPRODID { get; set; }
public string? WINPRODKEY { get; set; }
public string? WORKGROUP { get; set; }
public hardwareModel() {}
}
}
