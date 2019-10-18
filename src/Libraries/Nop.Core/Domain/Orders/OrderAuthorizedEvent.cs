namespace Nop.Core.Domain.Orders
{
    /// <summary>
    /// Represents an order authorized event.
    /// </summary>
    public class OrderAuthorizedEvent
    {
        /// <summary>
        /// Creates a new instance of <see cref="OrderAuthorizedEvent"/>.
        /// </summary>
        /// <param name="order">The order.</param>
        public OrderAuthorizedEvent(Order order)
        {
            Order = order;
        }

        /// <summary>
        /// Gets a order.
        /// </summary>
        public Order Order { get; }
    }
}
