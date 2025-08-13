using Application.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature.Command.CommandQuery.UpdateProduct
{
    public class UpdateProductQuey:IRequest
    {
        public  ProductDto ProductUpdate { get; set; }
        public int id { get; set; }
    }
}
