
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
    
public partial class D_DeviceModelItem
{

    public long ID { get; set; }

    public Nullable<long> DeviceModelID { get; set; }

    public string Name { get; set; }

    public string PropertyLabel { get; set; }

    public Nullable<long> ValueType { get; set; }

    public string Unit { get; set; }

    public string Description { get; set; }

    public Nullable<System.DateTime> StartDateTime { get; set; }

    public Nullable<System.DateTime> EndDateTime { get; set; }

    public Nullable<long> OrgID { get; set; }

}

}
