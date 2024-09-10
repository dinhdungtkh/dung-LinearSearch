using System.Reflection.Metadata.Ecma335;
namespace Dung.LinearSearch{
public class QueueLinkedList<T>
{
    private Node<T> head;
    private Node<T> tail;
    private int size;
    
    public  QueueLinkedList() {
        head = null;
        tail = null;
        size = 0 ;
    }
    
    public T Get()
    {   
       if (size == 0) throw new InvalidOperationException("Queue is empty.");
        T removed = head.Data;
        size--;
        head = head.Next; 
        return  removed;
    }
    public void Push(T item)
    {
        Node<T> newNode = new Node<T>(item);
        if (size == 0)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
        size++;
    }
    
    public int Count() { return size; } 
     public bool IsEmpty() { return size == 0; }
}
}