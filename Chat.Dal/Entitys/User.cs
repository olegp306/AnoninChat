﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Dal.Entitys
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}