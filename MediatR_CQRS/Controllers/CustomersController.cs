using MediatR;
using MediatR_CQRS.Application.Commands;
using MediatR_CQRS.Application.Queries;
using MediatR_CQRS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatR_CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet("all")]
        //public async Task<IActionResult> GetAll()
        //{
        //    var result= _mediator.Send(new Getcustomersquery)
        //}


        [HttpGet("{id}")]
        public async Task<IActionResult> Get( Guid id)
        {
            var result = await _mediator.Send(new GetCustomerByIdQuery
            {
                Id = id
            });

            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateCustomerModel createCustomerModel)
        {
            var customer = new Customer()
            {
                FirstName=createCustomerModel.FirstName,
                LastName=createCustomerModel.LastName,
                Birthday=createCustomerModel.Birthday,
                Age=createCustomerModel.Age,
                Phone=createCustomerModel.Phone
            };

            var result = await _mediator.Send(new CreateCustomerCommand
            {
                Customer=customer
            });

            return Ok(result);
        }



        [HttpPut("guid")]
        public async Task<IActionResult> Update([FromBody] UpdateCustomerModel updateCustomerModel)
        {
            

            var existCustomer = await _mediator.Send(new GetCustomerByIdQuery
            {
                Id = updateCustomerModel.Id
            });

            var customer = new Customer()
            {
                Id=updateCustomerModel.Id,
                FirstName=updateCustomerModel.FirstName,
                LastName=updateCustomerModel.LastName,
                Birthday=updateCustomerModel.Birthday,
                Age=updateCustomerModel.Age,
                Phone = updateCustomerModel.Phone

            };

            var result = await _mediator.Send(new UpdateCustomerCommand
            {
                Customer=customer
            });

            return Ok(result);
        }

    }
}
