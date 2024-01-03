using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Miras - Inheritance 
    public class Individual: Customer
    {
        
        public string IdentificationNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
