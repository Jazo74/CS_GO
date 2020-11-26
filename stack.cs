using System.Collections.Generic;

namespace stack
{
    // Interface for a stack
    interface IStack{
        void push(int item);
        int pop();
    }
    
    // My stack class
    class Stack : IStack
    {
        // a list which represents the stack
        private List<int> stackList = new List<int>();
        
        // the size of this stack
        private int stackSize;

        // Constructor
        public Stack(int stackSize){
            this.stackSize = stackSize;
        }

        // put an item to the end of the list(stack), till the list(stack) size lower the the stack size
        public void push(int item)
        {
            if (stackList.Count < this.stackSize)
            {
                stackList.Add(item);
            } else 
            {
                throw new System.StackOverflowException();
            }
        }

        // remove an item from the end of the list(stack), and return it, till the list(stack) has items.
        public int pop(){
            int output = stackList[stackList.Count-1];
            stackList.RemoveAt(stackList.Count-1);
            return output;
        }
    }
}

