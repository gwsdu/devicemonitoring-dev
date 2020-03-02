﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserBLL.Model.Parameter.Message
{
    public class UserMessageRelModel
    {
        public long ID { get; set; }
        public string Type { get; set; }
        public string Tittle { get; set; }
        public string Text { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<long> CreateUserID { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<long> UpdateUserID { get; set; }
        public List<string> UserID { get; set; }
        public string MessageID { get; set; }
        public string Status { get; set; }
    }
}
