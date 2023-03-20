using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsd2023_linq2
{
    public class RandomList<T>
    {
        private List<T> list;
        private Random rnd = new Random();
        public RandomList()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            if (rnd.NextDouble() < 0.5)
            {
                list.Insert(0, item);
            }
            else
            {
                list.Add(item);
            }
        }

        public T Get(int index)
        {
            return list[rnd.Next(index + 1)];
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }
    }
}
