using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

// Stack Implementation using Linked List
class Stack
{
    private Node top;

    public Stack()
    {
        top = null;
    }

    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = top;
        top = newNode;
        Console.WriteLine($"Pushed {data} to the stack.");
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty!");
            return -1;
        }
        int data = top.Data;
        top = top.Next;
        return data;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty!");
            return -1;
        }
        return top.Data;
    }

    public bool IsEmpty()
    {
        return top == null;
    }
}

// Queue Implementation using Linked List
class Queue
{
    private Node front;
    private Node rear;

    public Queue()
    {
        front = rear = null;
    }

    public void Enqueue(int data)
    {
        Node newNode = new Node(data);
        if (rear == null)
        {
            front = rear = newNode;
            Console.WriteLine($"Enqueued {data} to the queue.");
            return;
        }
        rear.Next = newNode;
        rear = newNode;
        Console.WriteLine($"Enqueued {data} to the queue.");
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty!");
            return -1;
        }
        int data = front.Data;
        front = front.Next;

        if (front == null)
            rear = null;

        return data;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty!");
            return -1;
        }
        return front.Data;
    }

    public bool IsEmpty()
    {
        return front == null;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Stack Operations:");
        Stack stack = new Stack();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        Console.WriteLine($"Top of stack: {stack.Peek()}");
        Console.WriteLine($"Popped from stack: {stack.Pop()}");
        Console.WriteLine($"Top of stack: {stack.Peek()}");

        Console.WriteLine("\nQueue Operations:");
        Queue queue = new Queue();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        Console.WriteLine($"Front of queue: {queue.Peek()}");
        Console.WriteLine($"Dequeued from queue: {queue.Dequeue()}");
        Console.WriteLine($"Front of queue: {queue.Peek()}");
    }
}