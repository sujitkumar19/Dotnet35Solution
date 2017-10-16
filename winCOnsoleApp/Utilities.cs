using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winCOnsoleApp
{
    public static class Utilities
    {
        public delegate bool DelFilter<S>(S value);
        public static List<T> Filter<T>(this List<T> sourceList,DelFilter<T> del)
        {
            List<T> temp = new List<T>();
            foreach (T item in sourceList)
            {
                if (del(item))
                {
                    temp.Add(item);

                }
            }
            return temp;
        }
        public static List<Employee> Filter (this List<Employee> sourceList)
        {
            List<Employee> temp = new List<Employee>();
            foreach (Employee item in sourceList)
            {
                if (item.Salary>1005)
                {
                    temp.Add(item);

                }
            }
            return temp;
        }
    }
}
