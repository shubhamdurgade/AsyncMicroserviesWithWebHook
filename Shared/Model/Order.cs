﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity {  get; set; }
        public DateTime Date { get; set; }

    }
}
