using Core.Commands;
using Core.Messages;

namespace Saga.Service.Commands
{
    public class CompensateStockCommand : ICompensateStockCommand
    {
        public IEnumerable<OrderItemMessage> Items { get; set; } = new List<OrderItemMessage>();
    }
}
