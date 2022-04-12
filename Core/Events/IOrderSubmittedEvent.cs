using Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Events
{
    public interface IOrderSubmittedEvent
    {
        int OrderId { get; }
        int UserId { get; }
        IEnumerable<OrderItemMessage> Items { get; }
    }
}
