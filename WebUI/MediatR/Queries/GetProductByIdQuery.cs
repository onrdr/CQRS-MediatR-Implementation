using MediatR;
using WebUI.Models;

namespace WebUI.MediatR.Queries;

public class GetProductByIdQuery : IRequest<GetProductViewModel>
{
    public Guid Id { get; set; }

    public GetProductByIdQuery(Guid id) => Id = id;
}
