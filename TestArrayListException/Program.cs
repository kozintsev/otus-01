using System.Collections;

namespace TestArrayListException
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            // Add an integer to the list.
            list.Add(3);
            // Add a string to the list. This will compile, but may cause an error later.
            list.Add("It is raining in Redmond.");

            var t = 0;
            // This causes an InvalidCastException to be returned.
            foreach (int x in list)
            {
                t += x;
            }
        }
    }
}
