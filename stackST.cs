using System.Collections.Generic;

namespace stack
{
      
    // My stack class
    class StackST : IStack
    {
        private static StackST singleStack = null;

        // the size of this stack
        private static int stackSize;

        // a list which represents the stack
        private List<int> stackList = new List<int>();

        // Constructor
        private StackST(){}

        public static StackST getSingleStack(int sSize){
            if (singleStack == null) {
                stackSize = sSize;
                singleStack = new StackST();
                return singleStack;
            } else 
            {
                return singleStack;
            }
        }

        // put an item to the end of the list(stack), till the list(stack) size lower the the stack size
        public void push(int item)
        {
            if (stackList.Count < stackSize)
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

