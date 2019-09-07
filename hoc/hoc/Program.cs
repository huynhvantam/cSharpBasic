using System;
using first_namespace;
using second_namespace;

namespace first_namespace
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("Ben trong namespace thu nhat!");
        }
    }
}

namespace second_namespace
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("Ben trong namespace thu hai!");
        }
    }
}

class TesCsharp
{
    static void Main(string[] args)
    {
        Console.WriteLine("namespace trong C#");
        Console.WriteLine("Vi du minh hoa cach su dung cua namespace");
        Console.WriteLine("------------------------------------------");

        first_namespace.namespace_cl fc = new first_namespace.namespace_cl();
        second_namespace.namespace_cl sc = new second_namespace.namespace_cl();
        fc.func();
        sc.func();
        Console.ReadKey();
    }
}