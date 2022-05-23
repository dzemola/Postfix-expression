
class Stack
{
    private Node _head; // Ref to the head of the list
    private Node _tail; // Ref to the tail of the list
    private int _length = 0; //Ref list length count
   
    
    public override string ToString()
    {
        Node temp = new Node();
        temp = this._head;
        string info = "";

        for (int i = 0; i <= _length; i++)
        {
            
            
            if (temp != null)
            {
                info = temp.Data.ToString() + (" ") + (info);
                temp = temp.Next;
            }
        }

        return info;
    }



    public void Push(object newData)
    {
        if (_head == null)
        {
            _head = new Node(); //Create new node at head
            _tail = _head; //Have tail ref head
            _tail.Data = newData; //Set data for tail

        }
        //Fill list with Nodes
        else
        {
            Node newNode = new Node(); //Create new Node
            newNode.Data = newData; //Set new Node data
            newNode.Next = _head; //Set new Node Next to current list head
            _head = newNode; //Set new Node to new head of list
            _length++; //Add list length count
        }

    }

    public object Pop()
    {
        object returnData = null;
        Node currentNode = _head;

        if (currentNode == null)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        else
        {
            returnData = _head.Data;

            if (currentNode != null && currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            if (currentNode != null)
            {
                currentNode.Next = null;
            }

            _head = currentNode;
            _length -= 1;

           
        }
        return returnData;
    }

    public object Peek()
    {

        return _head.Data;
    }

    public void Clear()
    {
        _head = null;
        _tail = null;
    }

    public bool IsEmpty()
    {
        bool empty = true;

        if (_head == null && _tail == null)
        {
            empty = true;
        }
        else
        {
            empty = false;
        }

        return empty;
    }
   

}