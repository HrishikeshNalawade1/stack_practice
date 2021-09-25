using System;
using System.Collections;

namespace stackk
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(23);
            st.Push("Hrishi");
            st.Push("kkk");
            st.Push(55);
            st.Push("karan");
            foreach(object tt in st)
            {
                Console.Write(tt+" ");
            }
            st.Pop();
            Console.WriteLine("\nAfter removing an item\n");
            foreach (object tt in st)
            {
                Console.Write(tt + " ");
            }
            Console.WriteLine("\nElements at top is: "+st.Peek());
            Console.WriteLine(st.Count);
        }
    }
}
