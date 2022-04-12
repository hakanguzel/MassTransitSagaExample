﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Events
{
    public interface IStockNotReservedEvent
    {
        Guid CorrelationId { get; }
        string Reason { get; }
    }
}
