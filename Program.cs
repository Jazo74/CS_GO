using System;
using stack;

namespace cs_go
{
    class Program
    {
        static void Main(string[] args)
        {
            int stackSize = 0;
            while (true){
                try {
                System.Console.WriteLine("Please enter the size of the stack: ");
                stackSize = Convert.ToInt32(System.Console.ReadLine());
                } catch (System.FormatException) {
                    System.Console.WriteLine("Wrong number!");
                    continue;
                }
                break;
            }
            Stack stackList = new Stack(stackSize);
            for (int item = 0; item < 100; item ++ ){
                try {
                    stackList.push(item);
                } catch (System.StackOverflowException) {
                    System.Console.WriteLine("Stack Owerflow!");
                    break;
                }
            }
            System.Console.WriteLine("Reading from stack:");
            while (true)
            {
                try {
                    System.Console.WriteLine(stackList.pop());
                } catch (System.ArgumentOutOfRangeException) 
                {
                    System.Console.WriteLine("The stack is empty!");
                    break;
                }
            }
        }

        class Start{

            public Stack Init()
            {
                int stackSize = 0;
                while (true){
                    try {
                    System.Console.WriteLine("Please enter the size of the stack: ");
                    stackSize = Convert.ToInt32(System.Console.ReadLine());
                    } catch (System.FormatException) {
                        System.Console.WriteLine("Wrong number!");
                        continue;
                    }
                    break;
                }
                return new Stack(stackSize);
            }
            
        }
    }
}
