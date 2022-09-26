namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }
        
        public void Print()
        {
            Console.Write("|" + data + "|->");
            if (next != null)
            {
                next.Print();
            }
        }

        public void Sort(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.Sort(data);
            }
        }

        public void AddFromEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddFromEnd(data);
            }
        }
    }

    public class MyList
    {
        public Node headNode;
        
        public MyList()
        {
            headNode = null;
        }
        
        public void AddFromEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else 
            { 
                headNode.AddFromEnd(data);
            }
        }
        
        public void Sort(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)
            {
                AddFromBegin(data);
            }
            else
            {
                headNode.Sort(data);
            }
        }       
        
        public void AddFromBegin(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);     
            }
            else
            {
                Node temp = new Node (data);
                temp.next = headNode;
                headNode = temp;
            }
        }
        
        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyList list = new MyList();
            
            //Adding elements in a linked list from end
            //list.AddFromEnd(9);
            //list.AddFromEnd(7);
            //list.AddFromEnd(11);
            //list.AddFromEnd(5);
            //list.AddFromEnd(10);
            //list.AddFromEnd(12);
            
            //Adding elements in a linked list from beginning
            //list.AddFromBegin(9);
            //list.AddFromBegin(7);
            //list.AddFromBegin(11);
            //list.AddFromBegin(5);
            //list.AddFromBegin(10);
            //list.AddFromBegin(12);
            
            //Sorting a Linked List
            list.Sort(9);
            list.Sort(7);
            list.Sort(11);
            list.Sort(5);
            list.Sort(10);
            list.Sort(12);

            list.Print();
            Console.ReadKey();
        }
    }
}