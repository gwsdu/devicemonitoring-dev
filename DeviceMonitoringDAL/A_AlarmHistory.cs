
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace DeviceMonitoringDAL
{

using System;
    using System.Collections.Generic;
    
public partial class A_AlarmHistory
{

    public long ID { get; set; }

    public long DeviceID { get; set; }

    public long DeviceItemID { get; set; }

    public long StrategyID { get; set; }

    public string Value { get; set; }

    public Nullable<System.DateTime> AlarmTime { get; set; }

    public Nullable<System.DateTime> EndTime { get; set; }

    public Nullable<long> OrgID { get; set; }

}

}
