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
    ///<summary>Peeks at a queue.</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        return (head.value);
    }
    ///<summary>Prints a queue.</summary>
    public void Print()
    {
        Node strider = head;
        if (strider == null)
            Console.WriteLine("Queue is empty");
        while (strider != null)
        {
            Console.WriteLine(strider.value.ToString());
            strider = strider.next;
        }
    }
    ///<summary>Concatenates all values in the queue only if the queue is of type String or Char</summary>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (null);
        }
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return (null);
        }
        string meow = "";
        Node strider = head;
        while (strider != null)
        {
            meow = meow + strider.value.ToString();
            if (strider != tail && typeof(T) == typeof(string))
                meow += " ";
            strider = strider.next;
        }
        return (meow);
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
