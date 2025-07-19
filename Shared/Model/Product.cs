﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

    }
}
