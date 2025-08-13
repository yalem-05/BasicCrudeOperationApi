using Application.Persistence;
using AutoMapper;
using Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature.Command.CommandQuery.UpdateProduct
{
    public class UpdateProductQueyHandler : IRequestHandler<UpdateProductQuey>
    {
        private readonly IproductRepository _productRepository;
        private readonly IMapper Mapper;
        public UpdateProductQueyHandler(IproductRepository productRepository, IMapper mapper)
        {
            _productRepository= productRepository;
            Mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateProductQuey request, CancellationToken cancellationToken)
        {
            var existingProduct = await _productRepository.GetByIdAsync(request.id);

            if (existingProduct == null)
                throw new Exception("Product not found");

            var update = request.ProductUpdate;

            if (!string.IsNullOrEmpty(update.description))
                existingProduct.description = update.description;

            if (!string.IsNullOrEmpty(update.pName))
                existingProduct.pName = update.pName;

            if (!string.IsNullOrEmpty(update.serialNo))
                existingProduct.serialNo = update.serialNo;

            
            await _productRepository.UpdateAsync(existingProduct);
            return Unit.Value;
            // throw new NotImplementedException();
        }
    }
}
