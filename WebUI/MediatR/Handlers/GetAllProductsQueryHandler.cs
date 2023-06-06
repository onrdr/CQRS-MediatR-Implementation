using MediatR;
using WebUI.Data;
using WebUI.Models;

namespace WebUI.MediatR.Queries;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<GetAllProductsViewModel>>
{
    public Task<List<GetAllProductsViewModel>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var list = new List<GetAllProductsViewModel>();
        var productList = ProductDataSeeder.GetAllProducts();

        foreach (var product in productList)
        {
            list.Add(new GetAllProductsViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Quantity = product.Quantity,
                Amount = product.Amount,
            });
        }

        return Task.FromResult(list);
    }
}

