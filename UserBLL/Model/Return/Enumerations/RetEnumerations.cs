﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserBLL.Model.Return.Enumerations
{
    public class RetEnumerations
    {
        public long ID { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        public string GroupName { get; set; }
        public Nullable<int> Position { get; set; }
        public Nullable<long> ParentID { get; set; }
        public bool Active { get; set; }
        public Nullable<long> OrgID { get; set; }
        public List<RetEnumerations> SecondLevel { get; set; }
    }
}
