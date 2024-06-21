
using System.Reflection;
using System;
using NUnit.Framework;
using TestingUnit;
using CustomerOrderService;
namespace MyUnitTestingTest1;
[TestFixture]
public class Tests
{
   [Test]
   public void shouldPrintHello(){
    Program program=new Program();
    Assert.That("Hello World",Is.EqualTo(program.PrintHello()));
   }
   
}
[TestFixture]
public class CustomerTest{
   [Test]
   public void shouldApplyDiscount(){
      Customers customers=new Customers();
      CustomerOrderServices customerOrderService=new CustomerOrderServices();
      Orders order=new Orders();
      customers.CustomerId=1;
      customers.CustomerName="User";
      customers.CustomerType=CustomerTypess.Basic;
      order.Amount=150;
      order.OrderId=1;
      order.ProductId=212;
      order.ProductQuantity=1;
      customerOrderService.ApplyDiscount(customers,order);
      Assert.That(150,Is.EqualTo(order.Amount));
   }
   [Test]
   public void shouldPremiumApplyDiscount(){
      Customers customers=new Customers();
      CustomerOrderServices customerOrderService=new CustomerOrderServices();
      Orders order=new Orders();
      customers.CustomerId=1;
      customers.CustomerName="User";
      customers.CustomerType=CustomerTypess.Premium;
      order.Amount=150;
      order.OrderId=1;
      order.ProductId=212;
      order.ProductQuantity=1;
      customerOrderService.ApplyDiscount(customers,order);
      Assert.That(135,Is.EqualTo(order.Amount));
   }
   [TestCase(120, ExpectedResult =false)]
   [TestCase(150, ExpectedResult=true)]
   public bool shouldSpecialCustomerApplyDiscount(int amount){
      Customers customers=new Customers();
      CustomerOrderServices customerOrderService=new CustomerOrderServices();
      Orders order=new Orders();
      customers.CustomerId=1;
      customers.CustomerName="User";
      customers.CustomerType=CustomerTypess.SpecialCustomer;
      order.Amount=amount;
      order.OrderId=1;
      order.ProductId=212;
      order.ProductQuantity=1;
      customerOrderService.ApplyDiscount(customers,order);
      bool result=(120==order.Amount);
      return result;
   }

}