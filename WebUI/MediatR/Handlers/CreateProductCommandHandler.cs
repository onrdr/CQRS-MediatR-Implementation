using MediatR;
using WebUI.Data;
using WebUI.Entities;

namespace WebUI.MediatR.Commands;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, string>
{
    public Task<string> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product()
        {
            Name = request.Name,
            Quantity = request.Quantity,
            Amount = request.Amount,
        };

        ProductDataSeeder.GetAllProducts().Add(product);

        return Task.FromResult($"Product Added successfully with ID: {product.Id}");
    }
}

