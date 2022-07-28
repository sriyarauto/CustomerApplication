using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib
{
    public class Coustomer
    {
        protected int cust_id;
        //protected string cust_name;
        //protected string cust_add;
        //protected string cust_phone;
        //protected string cust_city;
        //protected string cust_state;
        //protected int cust_pincode;
        //string cust_email_id;
        public int ID { get; set; }
        public string NAME { get; set; }
        public string ADD { get; set; }
        public string PHONE { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public int PINCODE { get; set; }
        public string EMAIL { get; set; }

    }
}