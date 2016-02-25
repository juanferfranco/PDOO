using N1;
using N2;

namespace N1
{
    public class C { }
}
namespace N2
{
    public class C { }

}
namespace NamespaceExample
{

    using CfromN1 = N1.C; //alias

    class Program
    {
        static void Main(string[] args)
        {
            //C c = new C(); // Compiler can't tell if you're using N1.C or N2.C.
            // N1.C c = new N1.C(); // Solution 1
            CfromN1 c = new CfromN1();
        }
    }
}
