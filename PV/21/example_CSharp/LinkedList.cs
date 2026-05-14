public class LinkedList<T>
{
    Node<T>? head = null;
    
    int count = 0;
    public int Count {get => count;}

    public void Add(T val)
    {
        Node<T> node = new(val);
        
        if(head == null)
        {
            head = node;
        }
        else
        {
            Node<T> iterNode = head;
            while(iterNode.Next != null)
            {
                iterNode = iterNode.Next;
            }

            iterNode.Next = node;
        }
        
        count++;
    }

    public T Get(int index)
    {
        if(count == 0)
        {
            throw new Exception("List is empty");
        }
        if(index >= count)
        {
            throw new Exception("Index out of bounds");
        }

        Node<T> node = head!;

        for(int i = 0; i < index; i++)
        {
            node = node.Next!;
        }

        return node.Value;
    }
    
    public void Remove(int index)
    {
        if(count == 0)
        {
            throw new Exception("List is empty");
        }
        if(index >= count)
        {
            throw new Exception("Index out of bounds");
        }

        if(index == 0)
        {
            head = null;
        }
        else
        {
            Node<T> prev = head!;

            for(int i = 0; i < index - 1; i++)
            {
                prev = prev.Next!;
            }

            prev.Next = prev.Next!.Next;
        }

        count--;
    }

    
}
