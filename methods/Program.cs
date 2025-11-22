using System;
using System.ComponentModel;

class program

{
    static int addNumbers(int a, int b)
    {
        return a + b;
    }

    static void greeting(string name)
    {
        Console.WriteLine("hello" + name);
    }
    static void Main()
    {
        greeting("nooeullah");
        int result = addNumbers(10, 20);
        {
            Console.WriteLine(result);
        }
    }
}

