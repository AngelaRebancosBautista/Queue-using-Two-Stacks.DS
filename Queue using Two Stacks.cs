using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
          int q = Convert.ToInt32(Console.ReadLine());
        Stack<int> stackNewest = new Stack<int>(); 
        Stack<int> stackOldest = new Stack<int>(); 

        for (int i = 0; i < q; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int type = int.Parse(input[0]);

            if (type == 1)
            {
                int x = int.Parse(input[1]);
                stackNewest.Push(x);
            }
            else if (type == 2)
            {
                if (stackOldest.Count == 0)
                {
                    while (stackNewest.Count > 0)
                        stackOldest.Push(stackNewest.Pop());
                }
                if (stackOldest.Count > 0)
                    stackOldest.Pop();
            }
            else if (type == 3)
            {
                if (stackOldest.Count == 0)
                {
                    while (stackNewest.Count > 0)
                        stackOldest.Push(stackNewest.Pop());
                }
                if (stackOldest.Count > 0)
                    Console.WriteLine(stackOldest.Peek());
            }
        }
    }
}
    
