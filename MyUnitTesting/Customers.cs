
namespace CustomerOrderService
{
    public class CustomerOrderServices
    {
        public void ApplyDiscount(Customers customer, Orders order)
        {
            if (customer.CustomerType.Equals( CustomerTypess.Premium))
            {
                order.Amount = order.Amount - ((order.Amount * 10) / 100);
            }
            else if(customer.CustomerType == CustomerTypess.SpecialCustomer)
            {
                order.Amount = order.Amount - ((order.Amount * 20) / 100);
            }
        }
    }
}