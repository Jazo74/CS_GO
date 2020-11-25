using System.Collections.Generic;

namespace stack
{
    class Stack
    {
        public Stack(){}

        public Stack(int stackSize){
            this.stackSize = stackSize;
        }
        private int stackSize = 1000;
        private List<int> stackList = new List<int>();

        public void push(int item)
        {
            if (stackList.Count < this.stackSize)
            {
                stackList.Add(item);
                System.Console.WriteLine(item + " has added to the stack");
            } else 
            {
                throw new System.StackOverflowException();
            }
        }
        public int pop(){
            int output = stackList[stackList.Count-1];
            stackList.RemoveAt(stackList.Count-1);
            return output;
        }
        
    }
}

