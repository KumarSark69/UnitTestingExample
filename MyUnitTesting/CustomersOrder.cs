
namespace CustomerOrderService
{
    public enum CustomerTypess
    {
        Basic,
        Premium,
        SpecialCustomer
    }
}

namespace CustomerOrderService
{
    public class Customers
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public CustomerTypess CustomerType { get; set; }
    }
}

namespace CustomerOrderService
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public decimal Amount { get; set; }
    }
}
