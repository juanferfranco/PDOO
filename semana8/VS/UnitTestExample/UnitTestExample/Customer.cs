using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    public class Customer
    {
        public string lastName { get; set; }

        public string firstName { get; set; }

        public string fullName {
            get
            {
                return firstName + ',' + lastName;
            }
        }
    }
}
