using Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Events
{
    public interface IPaymentRejectedEvent
    {
        Guid CorrelationId { get; }
        IEnumerable<OrderItemMessage> Items { get; }
        string Reason { get; }
    }
}
