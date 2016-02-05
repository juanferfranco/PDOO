using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class BingSearch:SearchEngine
    {
        public override string[] Search(string findThis)
        {
            //return base.Search(findThis);
            return new string[]
            {
                "res1", 
                "res2"
            };
        }
    }
}
