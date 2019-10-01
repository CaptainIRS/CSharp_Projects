using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Wrapper<string> stringWrapper = new Wrapper<string>();
            IWrapper<string> storedStringWrapper = stringWrapper;
            Console.WriteLine($"The stored data is : {storedStringWrapper.GetData()}");
            //GetData() can be accessed only through interface as it is defined explicitly in the class
            Console.ReadLine();
        }
    }
}
