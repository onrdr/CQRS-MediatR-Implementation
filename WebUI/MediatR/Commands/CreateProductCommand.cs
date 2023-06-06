using MediatR;

namespace WebUI.MediatR.Commands;

public class CreateProductCommand : IRequest<string>
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Amount { get; set; }
}
