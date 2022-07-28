using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            string add;
            string name;
            string state;
            string city;
            string phone;
            string email;
            int pincode;
            Customer c;
            CustomerArray ca = new CustomerArray();
            while(true)
            {
                Console.WriteLine("Enter your choice\n1.Add Customer\n2.Show All Customer\n3.Get Customer By Id\n4.Exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        Console.WriteLine("Name:");
                        name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Address:");
                        add= Convert.ToString(Console.ReadLine());
                        Console.WriteLine("City:");
                        city= Convert.ToString(Console.ReadLine());
                        Console.WriteLine("State:");

                        state= Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Pincode");
                        pincode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Email:");
                        email= Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Phone Number:");
                        phone= Convert.ToString(Console.ReadLine());
                        

                        int id = ca.Add(name, add, city, state, phone, email, pincode);
                        Console.WriteLine("Your Id is " + id);
                        break;
                    case 2:
                        ca.ShowALL();
                        break;
                    case 3:
                        Console.WriteLine("Enter Your Id");
                        int i = Convert.ToInt32(Console.ReadLine());

                        c = ca[i];
                        Console.WriteLine("...............................................");
                        Console.WriteLine("Customer ID: " + c.ID);
                        Console.WriteLine("Customer Name: " + c.NAME);
                        Console.WriteLine("Customer Address " + c.ADD);
                        Console.WriteLine("Customer State: " + c.STATE);
                        Console.WriteLine("Customer City: " + c.CITY);
                        Console.WriteLine("Customer Pincode: " + c.PINCODE);
                        Console.WriteLine("Customer Phone Number: " + c.PHONE);
                        Console.WriteLine("Customer Email: " + c.EMAIL);
                        Console.WriteLine("...............................................");
                        break;

                }
            }
        }
    }
}
