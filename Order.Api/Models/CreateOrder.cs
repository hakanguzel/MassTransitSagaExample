using Core.Commands;
using Core.Messages;

namespace Order.Api.Models
{
    public class CreateOrder : ICreateOrderCommand
    {
        public int UserId { get; set; }

        public List<OrderItemMessage> Items { get; set; }
    }
}
