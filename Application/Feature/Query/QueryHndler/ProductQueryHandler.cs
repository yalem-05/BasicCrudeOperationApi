using Application.Dto;
using Application.Feature.Query.Querys;
using Application.Persistence;
using AutoMapper;
using Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature.Query.QueryHndler
{
    public class ProductQueryHandler : IRequestHandler<ProductQuery, IEnumerable<ProductDto>>
    {
        private readonly IproductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductQueryHandler(IproductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository; 
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProductDto>> Handle(ProductQuery request, CancellationToken cancellationToken)
        {
            var val = await _productRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<ProductDto>>(val);
        }
    }
}
