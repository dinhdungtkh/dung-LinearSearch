using System;
using System.Collections.Generic;

using Dung.LinearSearch;

 public class StackExample<T>
  {
    
    private Stack<T> _stack = new Stack<T>();
    private List<T> items = new List<T>();

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Get()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }


    public int size()
    {
        return items.Count;
    }

    
  }
