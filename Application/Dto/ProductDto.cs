﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class ProductDto
    {
       // public int Id { get; set; }
        public  String? pName { get; set; }

        public string? serialNo { get; set; }
        public string? description { get; set; }
        public decimal? price { get; set; }
    }
}
