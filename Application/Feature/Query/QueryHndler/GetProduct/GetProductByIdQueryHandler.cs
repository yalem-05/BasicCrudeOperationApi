using Application.Dto;
using Application.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature.Query.QueryHndler.GetProduct
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, int>
    {
        private readonly IproductRepository _productRepository;
        public GetProductByIdQueryHandler(IproductRepository productRepository)
        {
            _productRepository= productRepository;
        }
        public async Task<int> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.id);
            if (product == null)
            {
                throw new KeyNotFoundException($"Product with id {request.id} not found.");
            }
            await _productRepository.DeleteAsync(product);
            return product.Id;

           // throw new NotImplementedException();
        }
    }
}
