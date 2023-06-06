using MediatR;
using WebUI.Models;

namespace WebUI.MediatR.Queries;

public class GetAllProductsQuery : IRequest<List<GetAllProductsViewModel>>
{

}
