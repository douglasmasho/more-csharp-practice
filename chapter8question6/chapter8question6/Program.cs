using System;
/*
 Write a program named InputMethodDemo2 that eliminates the repetitive code 
in the InputMethod() in the InputMethodDemo program in Figure 8-5. Rewrite the 
program so the InputMethod() contains only two statements:
one = DataEntry("first");
two = DataEntry("second");
 */

namespace chapter8question6
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second;
            InputMethod(out first, out second);
            Console.WriteLine("After InputMethod first is {0}", first);
            Console.WriteLine("and second is {0}", second);
        }
        private static void InputMethod(out int one, out int two)
        {
            one = DataEntry("first");
            two = DataEntry("second");
        }
        private static int DataEntry(string position)
        {
            Console.WriteLine($"Enter {position} integer");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
