﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class CartItem
    {
        public int quantity { set; get; }
        public Product product { set; get; }
    }
}
