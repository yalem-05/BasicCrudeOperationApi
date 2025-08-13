using Application.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature.Query.QueryHndler.GetProduct
{
    public class GetProductByIdQuery: IRequest<int>
    {
        public int id { get; set; }
    }
}
