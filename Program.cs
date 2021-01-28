using System;

using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bankada Müşteri Takibi!");
            Customer customer1 = new Customer() {
                FirstName = "Ayşe",
                LastName="Özateş"
            
            
            };
            Customer customer2 = new Customer()
            {
                FirstName = "Fatma",
                LastName = "özateş"


            };
            List<Customer> customers = new List<Customer>() { customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customers);
            customerManager.ListCustomer(customers);
            customerManager.DeleteCustomer(customers);

        }
    }
}
