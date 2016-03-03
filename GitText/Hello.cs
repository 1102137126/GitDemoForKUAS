using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitText
{
    public class Hello
    {
        public static void Main() {
            System.Console.WriteLine("Shhhhhh");
            System.Console.WriteLine("Hiiiiiii");
            System.Console.WriteLine("Hiiiiiii");
            System.Console.WriteLine("Hiiiiiii");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j <= i)
                    {
                        System.Console.Write("*");
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.ReadLine();
        }
    }
    //123
}