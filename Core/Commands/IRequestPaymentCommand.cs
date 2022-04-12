using Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Commands
{
    public interface IRequestPaymentCommand
    {
        Guid CorrelationId { get; }
        decimal TotalPrice { get; }
        IEnumerable<OrderItemMessage> Items { get; }
    }
}
