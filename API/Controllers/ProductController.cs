using Application.Dto;
using Application.Feature.Command.CommandQuery;
using Application.Feature.Command.CommandQuery.UpdateProduct;
using Application.Feature.Query.QueryHndler.GetProduct;
using Application.Feature.Query.QueryHndler.GetProduct.getById;
using Application.Feature.Query.Querys;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediatr;

        public ProductController(IMapper mapper, IMediator mediatr)
        {
                _mapper = mapper;
                _mediatr = mediatr;
        }

        [HttpGet("getAllData")]

        public async Task<IActionResult> GetAllData()
        {
            var result = await _mediatr.Send(new ProductQuery());
            return Ok(result);
        }

        [HttpPost("Create data")]

        public async Task<IActionResult> CreateProduct([FromBody] ProductDto productDto)
        {
            //var command = new ProductCommandQuery { Productdtoquey = productDto };
            //await _mediatr.Send(command);
            //return Ok(command);
            var result = await _mediatr.Send(new ProductCommandQuery{ Productdtoquey=productDto});
            return Ok(result);
        }
        [HttpDelete("DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await _mediatr.Send(new GetProductByIdQuery { id = id });
            return Ok(result);
        }
        [HttpPut("updateProduct/{id}")]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductDto productDto, int id)
        {
            // Assuming you have an update command similar to the create command
            var command = new UpdateProductQuey { ProductUpdate = productDto , id=id};
            var result = await _mediatr.Send(command);
            return Ok(result);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetByIdS(int id)
        {
            var val = new GetByIdQuery { id = id };
            var res = await _mediatr.Send(val);

            return Ok(res);
         }
    }
}
