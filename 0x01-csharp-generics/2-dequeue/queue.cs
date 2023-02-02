﻿using System;

///<summary>Generic queue class implementation.</summary>
public class Queue<T>
{
    ///<summary>Head of a queue.</summary>
    public Node head = null;
    ///<summary>Tail of a queue.</summary>
    public Node tail = null;
    int count = 0;

    ///<summary>Checks type of parameter.</summary>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }
    ///<summary>Adds to a queue.</summary>
    public void Enqueue(T val)
    {
        Node neww = new Node(val);
        if (head == null && tail == null)
        {
            head = neww;
            tail = neww;
        }
        else
        {
            tail.next = neww;
            tail = neww;
        }
        count += 1;
    }
    ///<summary>Removes from a queue.</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        Node old = head;
        head = old.next;
        count -= 1;
        return (old.value);
    }
    ///<summary>Counts a queue.</summary>
    public int Count()
    {
        return (count);
    }

    ///<summary>Queue nodes.</summary>
    public class Node
    {
        ///<summary>Value of a node.</summary>
        public T value = default(T);
        ///<summary>Next node.</summary>
        public Node next = null;

        ///<summary>Constructor for Node.</summary>
        public Node (T temp)
        {
            value = temp;
        }
    }
}
