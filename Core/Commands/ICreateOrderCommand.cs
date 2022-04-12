using Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Commands
{
    public interface ICreateOrderCommand
    {
        int UserId { get; }
        List<OrderItemMessage> Items { get; }
    }
}
