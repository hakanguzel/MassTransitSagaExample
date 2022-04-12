﻿using Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Events
{
    public interface IStockReservedEvent
    {
        Guid CorrelationId { get; }
        IEnumerable<OrderItemMessage> Items { get; }
    }
}
