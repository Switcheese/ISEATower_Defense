using System;
using System.Collections.Generic;

using System.Threading.Tasks;

public class CirCularQueue
{
    static public int ArraySize = 10;
    int front = 0, rear = 0;
    int[] arr = new int[ArraySize];
    public void Enqueue(int data)
    {
        if ((rear + 1) % ArraySize == front % ArraySize)
        {
            //System.out.println("CircularQueue Full!!");
        }
        else
        {
            rear = (rear + 1) % ArraySize;
            arr[rear] = data;
        }
    }
    public void Dequeue()
    {
        if (front == rear)
        {
           // System.out.println("CircularQueue Empty!!");
        }
        else
        {
            front = (front + 1) % ArraySize;
           // System.out.println(arr[front]);
        }
    }
    public void showArray()
    {
        for (int i = 1; i < ArraySize; i++)
        {
           // System.out.print(arr[i] + " ");
        }
        //System.out.println();
    }
    public int getFront()
    {
        return arr[front + 1];
    }
}
