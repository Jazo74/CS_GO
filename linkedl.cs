using System.Collections.Generic;

namespace cs_go

{
    public class LinkedL{
        private LinkedList<int> myList = new LinkedList<int>();

        public LinkedL(){
            for (int value = 0; value < 55; value ++){
                this.AddItem(value);
            }
        }
        private void AddItem(int item){
            LinkedListNode<int> node = new LinkedListNode<int>(item);
            myList.AddLast(node);
        }
        public void ReadAsc(){
            ReadNext(this.myList.First);
        }

        public void ReadDesc(){
            ReadPrevious(this.myList.Last);
        }

        private void ReadNext(LinkedListNode<int> node){
            System.Console.Write(node.Value + ", ");
            if (node.Next != null){
                ReadNext(node.Next);
            }
        }

        private void ReadPrevious(LinkedListNode<int> node){
            System.Console.Write(node.Value + ", ");
            if (node.Previous != null){
                ReadPrevious(node.Previous);
            }
        }
    }
}