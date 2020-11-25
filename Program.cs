using System;
using stack;

namespace cs_go
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Start start = new Start();
            start.Init();
            start.Pushes();
            start.Pops();

            Console.ReadKey();
            
            LinkedListReader myLL = new LinkedListReader();
            myLL.ReadAll();
            
            Console.ReadKey();
        }

        class Start{
            private Stack myStack;
            public void Init()
            {
                int stackSize;
                while (true){
                    try {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.WriteLine("Please enter the size of the stack: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    stackSize = Convert.ToInt32(System.Console.ReadLine());
                    } catch (System.FormatException) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Wrong number!");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    break;
                }
                this.myStack = new Stack(stackSize);
            }

            public void Pushes()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine();
                System.Console.WriteLine("--------------- Adding to stack: -----------------");
                Console.ForegroundColor = ConsoleColor.White;
                for (int item = 0; item < 100; item ++ )
                {
                    try {
                        this.myStack.push(item);
                        System.Console.Write(item + ", ");
                    } catch (System.StackOverflowException) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Stack Owerflow!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
            }

            public void Pops()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine();
                System.Console.WriteLine("--------------- Reading from stack: -----------------");
                Console.ForegroundColor = ConsoleColor.White;
                while (true)
                    {
                        try {
                            System.Console.Write(this.myStack.pop() + ", ");
                        } catch (System.ArgumentOutOfRangeException) 
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            System.Console.WriteLine("The stack is empty!");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
            }

        }
    }

    public class LinkedListReader{

        LinkedL myLinkedL;
        public LinkedListReader(){
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine();
            System.Console.WriteLine("Creating sample linked list...");
            Console.ForegroundColor = ConsoleColor.White;

            this.myLinkedL = new LinkedL();
        }
        public void ReadAll(){
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine();
            System.Console.WriteLine("----------- Reading through the linked list: ----------");
            Console.ForegroundColor = ConsoleColor.White;

            this.myLinkedL.ReadAsc();
            System.Console.WriteLine();
            this.myLinkedL.ReadDesc();
        }
    }
}
