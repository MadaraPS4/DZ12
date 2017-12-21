using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int>();

            for(int i=0; i<=50; i++)
            {
                collection.Add(i);
            }

            var max = collection.Max();
            var secondMax = collection[0];
            for(int i=0; i<collection.Count; i++)
            {
                if (collection[i] < max)
                {
                    if (collection[i] > secondMax)
                    {
                        secondMax = collection[i];
                    }

                }
               
            }

            Console.WriteLine("Второй максимальный элемент в коллекций = " + secondMax);

            int sum = 0;
            for(int i=2; i<=collection.Count; i = i + 2)
            {
                sum += collection[i];
            }

            Console.WriteLine("Сумма элементов на четных позициях = "+sum);


            Console.ReadKey();
        }
    }
}
