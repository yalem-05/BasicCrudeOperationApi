using Application.Dto;
using Application.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature.Query.QueryHndler.GetProduct.getById
{
    public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, ProductDto>
    {
        private readonly IproductRepository _productRepository;
        private readonly IMapper _mapper;
        public GetByIdQueryHandler(IproductRepository productRepository, IMapper mapper)
        {
      _productRepository= productRepository;
            _mapper = mapper;
        }
        public async Task<ProductDto> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.id);
            if (product == null)
            {
                throw new KeyNotFoundException($"Product with id {request.id} not found.");
            }
            return _mapper.Map<ProductDto>(product);

            //throw new NotImplementedException();
        }
    }
}
