﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveUp.Models
{
    // Item Model
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime Date {  get; set; }
        public decimal Price { get; set; }
    }
}
