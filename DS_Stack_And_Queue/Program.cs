using System;

namespace DS_Stack_And_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Creating Stack & Queue Operations-------------------");
            Console.WriteLine("***************************************************************************");
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {

              
                Console.WriteLine("-------Stack Operation----- \n1.Push Operation \n2.Pop and Peek Operation\n \n------Queue Operation------- \n3.EnQueue Operation \n4.DeQueue Operation\n");
                Console.WriteLine("     Enter Your option  1,2,3,4  \n ");
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
                    case 2:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);

                        Console.WriteLine("----------------------------------Using Peek method");
                        //Console.WriteLine("Using Peek method");
                        stack.Pop();
                        stack.Display();
                        break;
                    case 3:
                        Queue queue = new Queue();
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        Console.WriteLine("===============================");
                        queue.Display();
                        break;

                    case 4:
                        Queue queue1 = new Queue();
                        queue1.Enqueue(56);
                        queue1.Enqueue(30);
                        queue1.Enqueue(70);
                        Console.WriteLine("--------deque");
                        queue1.Dequeue();
                        Console.WriteLine("===============================");
                        queue1.Display();
                        break;

                    default:
                        Console.WriteLine("Enter a valid option");
                        break;

                }
                Console.WriteLine("\nDo you want to continue?(Y/N)");
                flag = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
