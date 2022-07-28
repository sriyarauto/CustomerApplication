using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerLib;
using System.Collections;
namespace Customer
{
    class CustomerArray
    {
        ArrayList CArray = new ArrayList();
        public Customer this[int i]
        {

            get
            {

                Customer temp = null;
                IEnumerator e;
                e = CArray.GetEnumerator();
                while (e.MoveNext())
                {
                    temp = (Customer)e.Current;
                    if (temp.ID == i)
                    {
                        break;
                    }

                }
                return temp;


            }
           
        }
        static int num;
        
        static int i = 0;
        public  int Add(string name,string add,string city,string state,string phone,string email,int pincode)
        { Customer c = new Customer();
            c.NAME = name;
            c.PHONE = phone;
            c.ADD = add;
            c.CITY = city;
            c.EMAIL = email;
            c.STATE = state;
            c.PINCODE = pincode;
            c.ID = ++i;
            CArray.Add(c);
            return i;
        }
        public void ShowALL()
        {
            Customer c = null;
            IEnumerator e;
            e = CArray.GetEnumerator();
            while(e.MoveNext())
            {
                c = (Customer)e.Current;
                Console.WriteLine("...............................................");
                Console.WriteLine("Customer ID: "+c.ID);
                Console.WriteLine("Customer Name: " + c.NAME);
                Console.WriteLine("Customer Address " + c.ADD);
                Console.WriteLine("Customer State: "+c.STATE);
                Console.WriteLine("Customer City: "+c.CITY);
                Console.WriteLine("Customer Pincode: "+c.PINCODE);
                Console.WriteLine("Customer Phone Number: "+c.PHONE);
                Console.WriteLine("Customer Email: "+c.EMAIL);
                Console.WriteLine("...............................................");



            }
        }
   


    }
    
}
