using System;

namespace AnotherBlockApp
{
    class LocalVariableApp
    {
        static int x;
        static void Main(string[] args)
        {
            int x = (LocalVariableApp.x = 2) * 2;
            Console.WriteLine("static x = " +LocalVariableApp.x);
            Console.WriteLine("local x = " +x);


        }
    }
}
