using System;

namespace _0_safe_list_print
{
    class List
    {
        public static int SafePrint(List<int> myList, int n)
        {
        int i = 0;
        try
        {
            for (; i < n; i++)
                Console.WriteLine(myList[i]);
        }
        catch (Exception)
        {
            return (i);
        }
        return (i);  
        }
    }
}
