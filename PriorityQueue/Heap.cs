﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

using System;

public class Heap
{
    private int size;
    private int last;
    private int[] priorities;

    public Heap(int size)
    {
        this.size = size;
        priorities = new int[size + 1];
        last = 0;
    }

    public void Insert(int value)
    {
        if (last >= size)
            throw new Exception("Heap je pun!");

        last++;
        priorities[last] = value;
        BubbleUp(last);
    }

    public int Retrieve()
    {
        if (last == 0)
            throw new Exception("Heap je prazan!");

        int root = priorities[1];
        priorities[1] = priorities[last];
        last--;
        BubbleDown(1);
        return root;
    }

    public void BubbleUp(int i)
    {
        if (i == 1) return;

        int parent = i / 2;
        if (priorities[i] > priorities[parent])
        {
            Swap(i, parent);
            BubbleUp(parent);
        }
    }

    public void BubbleDown(int i)
    {
        int left = 2 * i;
        int right = 2 * i + 1;
        int largest = i;

        if (left <= last && priorities[left] > priorities[largest])
            largest = left;

        if (right <= last && priorities[right] > priorities[largest])
            largest = right;

        if (largest != i)
        {
            Swap(i, largest);
            BubbleDown(largest);
        }
    }

    public void Swap(int first, int second)
    {
        int temp = priorities[first];
        priorities[first] = priorities[second];
        priorities[second] = temp;
    }

    public void Display()
    {
        for (int i = 1; i <= last; i++)
            Console.Write(priorities[i] + " ");
        Console.WriteLine();
    }
}
