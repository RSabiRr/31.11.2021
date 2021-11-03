using Library1;
using System;

namespace Access_modifiers__Namespace__Library
{
    class Program :Class1
    {
        static void Main(string[] args)
        {

            Class1 class1 = new Class1();
            class1.a = 3;
            class1.b = 4;

            Console.WriteLine(Class1.toplama(3,4));

            Console.WriteLine(Class1.vurma(class1.a, class1.b));
        }

       
    }
}
