﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Harmony.Models
{
    public class Rating
    {
        public int ID { get; set; }

        public int Value { get; set; }

        public int? UserID { get; set; }
    }
}