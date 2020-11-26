using System.Collections.Generic;

namespace cs_go

{
    class LinkedL{

        // The linked list
        private LinkedList<int> myList = new LinkedList<int>();

        // Constructor, make a sample linked list
        public LinkedL(){ 
            for (int value = 0; value < 50; value ++){
                this.AddItem(value);
            }
        }

        // Add a new node to the linked list
        private void AddItem(int item){ 
            LinkedListNode<int> node = new LinkedListNode<int>(item);
            myList.AddLast(node);
        }

        // starts the reading with the first node
        public void ReadAsc(){
            ReadForward(this.myList.First);
        }

        // starts the reading with the last node
        public void ReadDesc(){
            ReadBackward(this.myList.Last);
        }

        // recursive forward reading
        private void ReadForward(LinkedListNode<int> node){
            System.Console.Write(node.Value + ", ");
            if (node.Next != null){
                ReadForward(node.Next);
            }
        }

        // recursive backward reading
        private void ReadBackward(LinkedListNode<int> node){
            System.Console.Write(node.Value + ", ");
            if (node.Previous != null){
                ReadBackward(node.Previous);
            }
        }
    }
}