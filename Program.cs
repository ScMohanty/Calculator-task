using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace ConsoleApp3

{
    class Program
    {
        int i;
        int j;
        string d;
        static void Addition(int i, int j, out int result)
        {
            i = i;
            j = j;
            result = i + j;
        }
        static void Multipication(int i, int j, out int result1)
        {
            i = i;
            j = j;
            result1 = i * j;
        }
        static void Substraction(int i, int j, out int result2)
        {
            i = i;
            j = j;
            result2 = i - j;
        }
        static void main(string[] args)
        {
          
                Program p = new Program();

                Console.WriteLine("ENTER THE NUMBER BASED ON OPTIONS");
                Console.WriteLine("PRESS 1 FOR ADDITION");
                Console.WriteLine("PRESS 2 FOR MULTIPICATION");
                Console.WriteLine("PRESS 3 FOR SUBSTRACTION");
                int enter;
                enter = Convert.ToInt32(Console.ReadLine());




                switch (enter)
                {
                    case 1:

                        int result = 0;
                        Console.WriteLine("enter 1st number");
                        p.i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter 2nd number");
                        p.j = Convert.ToInt32(Console.ReadLine());
                        Addition(p.i, p.j, out result);
                        Console.WriteLine(result);


                        break;

                    case 2:
                        int result1 = 0;
                        Console.WriteLine("enter 1st number");
                        p.i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter 2nd number");
                        p.j = Convert.ToInt32(Console.ReadLine());
                        Multipication(p.i, p.j, out result1);
                        Console.WriteLine(result1);
                        break;

                    case 3:
                        int result2 = 0;
                        Console.WriteLine("enter 1st number");
                        p.i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter 2nd number");
                        p.j = Convert.ToInt32(Console.ReadLine());
                        Substraction(p.i, p.j, out result2);
                        Console.WriteLine(result2);
                        break;

                }
           
                Console.WriteLine("DO YOU WANT ANYTHING ELSE");
                string d;
                d = Console.ReadLine();
                Console.WriteLine("ENTER THE NUMBER BASED ON OPTIONS");
                Console.WriteLine("PRESS 1 FOR ADDITION");
                Console.WriteLine("PRESS 2 FOR MULTIPICATION");
                Console.WriteLine("PRESS 3 FOR SUBSTRACTION");

                enter = Convert.ToInt32(Console.ReadLine());


          
            while (d != "NO")
            {

                switch (enter)
                {
                    case 1:

                        int result = 0;
                        Console.WriteLine("enter 1st number");
                        p.i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter 2nd number");
                        p.j = Convert.ToInt32(Console.ReadLine());
                        Addition(p.i, p.j, out result);
                        Console.WriteLine(result);


                        break;

                    case 2:
                        int result1 = 0;
                        Console.WriteLine("enter 1st number");
                        p.i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter 2nd number");
                        p.j = Convert.ToInt32(Console.ReadLine());
                        Multipication(p.i, p.j, out result1);
                        Console.WriteLine(result1);
                        break;

                    case 3:
                        int result2 = 0;
                        Console.WriteLine("enter 1st number");
                        p.i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter 2nd number");
                        p.j = Convert.ToInt32(Console.ReadLine());
                        Substraction(p.i, p.j, out result2);
                        Console.WriteLine(result2);
                        break;
                }
            }



        }


    }
}
        
     
    

