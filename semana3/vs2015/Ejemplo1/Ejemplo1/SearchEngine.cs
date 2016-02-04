using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class SearchEngine
    {

        public SearchEngine()
        {

        }

        public virtual string[] Search(string findThis)
        {
            return new string[0];
        }
    }
    
}
