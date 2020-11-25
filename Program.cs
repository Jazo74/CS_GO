using System;
using stack;

namespace cs_go
{
    class Program
    {
        static void Main(string[] args)
        {
            Start start = new Start();
            Stack myStack = start.Init();
            start.Pushes();
            System.Console.WriteLine();
            System.Console.WriteLine("Reading from stack:");
            System.Console.WriteLine();
            start.Pops();
        }

        class Start{

            private Stack myStack;
            public Stack Init()
            {
                int stackSize;
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
                this.myStack = new Stack(stackSize);
                return this.myStack;
            }

            public void Pushes()
            {
                for (int item = 0; item < 100; item ++ )
                {
                    try {
                        this.myStack.push(item);
                    } catch (System.StackOverflowException) {
                        System.Console.WriteLine("Stack Owerflow!");
                        break;
                    }
                }
            }

            public void Pops()
            {
                while (true)
                    {
                        try {
                            System.Console.WriteLine(this.myStack.pop());
                        } catch (System.ArgumentOutOfRangeException) 
                        {
                            System.Console.WriteLine("The stack is empty!");
                            break;
                        }
                    }
            }

        }
    }
}
