using System;


namespace Ejercicio4
{
    class GoogleSearch:SearchEngine
    {
        public GoogleSearch()
        {

        }

        public override string[] Search(string findThis)
        {
            return new string[]{
                "resultado 1",
                "resultado 2",
                "resultado 3" };
        }
    }
}
