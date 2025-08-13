using Application.Dto;
using Application.Feature.Command.CommandQuery;
using Application.Persistence;
using AutoMapper;
using Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature.Command.CommandqueryHandler
{
    public class ProductCommandQueryHandler : IRequestHandler<ProductCommandQuery, ProductDto>
    {
        private readonly IproductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductCommandQueryHandler(IproductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<ProductDto> Handle(ProductCommandQuery request, CancellationToken cancellationToken)
        {
            var productEntity = _mapper.Map<ProductUpdate>(request.Productdtoquey);
            var addedProduct = await _productRepository.AddAsync(productEntity);
            return _mapper.Map<ProductDto>(addedProduct);
            // throw new NotImplementedException();
        }
    }
}
