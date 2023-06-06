using MediatR;
using WebUI.Data;
using WebUI.Models;

namespace WebUI.MediatR.Queries;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
{
    public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = ProductDataSeeder.GetProductById(request.Id);

        if (product is null)
        {
            return Task.FromResult(new GetProductViewModel());
        }

        return Task.FromResult(new GetProductViewModel()
        {
            Name = product.Name,
            Quantity = product.Quantity,
            Amount = product.Amount
        });
    }
}

