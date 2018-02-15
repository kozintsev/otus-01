using System;
using System.Collections;
using System.Collections.Generic;

namespace TestArrayListException
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList test

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

            #endregion

            #region List test

            // The .NET Framework 2.0 way to create a list
            var list1 = new List<int>();

            // No boxing, no casting:
            list1.Add(3);

            // Compile-time error:
            // list1.Add("It is raining in Redmond.");

            #endregion

            #region Cast to Object

            // The .NET Framework 2.0 way to create a list
            var list2 = new List<object>();

            // No boxing, no casting:
            list2.Add(3);

            // Compile-time error:
            list2.Add("It is raining in Redmond.");

            #endregion

        }
    }
}
