
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
    
public partial class D_Devices
{

    public long ID { get; set; }

    public string DeviceType { get; set; }

    public string Name { get; set; }

    public string DeviceLabel { get; set; }

    public Nullable<long> DeviceModelID { get; set; }

    public Nullable<int> ConnectType { get; set; }

    public Nullable<long> IoTHubID { get; set; }

    public Nullable<long> DataConnectID { get; set; }

    public string TagMap { get; set; }

    public string GPS { get; set; }

    public string Phone { get; set; }

    public Nullable<int> Status { get; set; }

    public string Remark { get; set; }

    public Nullable<System.DateTime> CreateTime { get; set; }

    public Nullable<long> CreateUserID { get; set; }

    public Nullable<System.DateTime> UpdateTime { get; set; }

    public Nullable<long> UpdateUserID { get; set; }

    public Nullable<long> OrgID { get; set; }

    public string Manufacturer { get; set; }

    public Nullable<int> RunningState { get; set; }

    public string Specification { get; set; }

    public long GroupID { get; set; }

}

}