﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserBLL.Model.Return.User;

namespace UserBLL.Model.Return.Message
{
    public class RetMessageInfo
    {
        public string ID { get; set; }
        public string Type { get; set; }
        public string Tittle { get; set; }
        public string Text { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<long> CreateUserID { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<long> UpdateUserID { get; set; }
        public List<RetUserInfo> UserInfo { get; set; }
    }
}
