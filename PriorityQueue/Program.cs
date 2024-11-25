using System;

class Program
{
    static void Main(string[] args)
    {
      
        Heap heap = new Heap(10);

        
        try
        {
            for (int i = 0; i < 11; i++) 
                heap.Insert(i);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        heap.Display();

        try
        {
            while (true)
            {
                int priority = heap.Retrieve();
                heap.Display();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
