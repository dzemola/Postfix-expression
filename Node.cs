
class Node
{
    private object _data;
    private Node _next;

    public object Data
    {
        get { return _data; }
        set { _data = value; }
    }
    public Node Next
    {
        get { return _next; }
        set { _next = value; }
    }

    public Node(object initailData = null)
    {
        _data = initailData;
    }//end constructor

}

