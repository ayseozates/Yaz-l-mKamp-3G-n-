using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer (List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Müsteri Sisteme Başarıyla eklendi :" + customer.FirstName + " " + customer.LastName);
            }

           
        }
        public void ListCustomer(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Müsteriler listelendi :" + customer.FirstName + " " + customer.LastName);
            }

        }
        public void DeleteCustomer(List<Customer> customers)
        {
            Console.WriteLine("Müsteri Başarıyla Sistemden Silindi");
        }
    }
}
