using System;

namespace DS_Stack_And_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Creating Stack Operations-------------------");
            Console.WriteLine("---------------1.Push operation--------------");
            Console.WriteLine("Enter the option");
            int num = Convert.ToInt32(Console.ReadLine());
            Stack stack = new Stack();
            switch (num)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    Console.WriteLine("==================================");
                    stack.Display();
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
