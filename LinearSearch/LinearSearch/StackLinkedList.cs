using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
public class StackLinkedList<T>
{
	private int size;
	private Node<T> head = null;


	public StackLinkedList()
	{
		size = 0;
		head = null;
	}

	public T get()
	{
		if (size == 0)
			throw new InvalidOperationException("Stack is empty");
		T removed = head.Data;
		head = head.Next;			

		size--;
		return removed;
	}

	public T Peek()
	{

		return head.Data;
	}

	public void push(T item)
	{
		Node<T> newNode = new Node<T>(item);
		newNode.Next = head;
		head = newNode;
		size++;

	}

	public int Count() { return size; }


}
