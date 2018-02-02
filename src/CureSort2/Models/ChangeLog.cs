﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CureSort2.Models
{
    public class ChangeLog
    {
        public string ClassName { get; set; }
        public string PropertyName { get; set; }
        public int PrimaryKey { get; set; }
        public string EditBy { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime DateChanged { get; set; }
    }
}
