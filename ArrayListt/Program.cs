using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ArrayListt
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Array = new ArrayList();
            for (int intIndex = 0; intIndex <= 5; intIndex++)
            {
                Array.Add(intIndex);
            }
            Array.RemoveAt(0);
            Array.Add(8);
            foreach (int item in Array)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
