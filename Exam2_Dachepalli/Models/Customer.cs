﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam2_Dachepalli.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}