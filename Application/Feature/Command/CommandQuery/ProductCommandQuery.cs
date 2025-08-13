﻿using Application.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature.Command.CommandQuery
{
    public class ProductCommandQuery: IRequest<ProductDto>
    {
        public ProductDto Productdtoquey { get; set; }
    }
}
