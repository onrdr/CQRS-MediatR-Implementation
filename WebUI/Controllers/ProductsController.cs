using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebUI.MediatR.Commands;
using WebUI.MediatR.Queries;

namespace WebUI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var query = new GetProductByIdQuery(id);

        return Ok(await _mediator.Send(query)); 
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var query = new GetAllProductsQuery();

        return Ok(await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateProductCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
}