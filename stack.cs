using System.Collections.Generic;

namespace stack
{
    public class Stack
    {
        public Stack(int stackSize){
            this.stackSize = stackSize;
        }
        private int stackSize;
        private List<int> stackList = new List<int>();

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
        public int pop(){
            int output = stackList[stackList.Count-1];
            stackList.RemoveAt(stackList.Count-1);
            return output;
        }
    }
}

