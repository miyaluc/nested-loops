using System;

namespace nested_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yo Josie, check out your gardens!");
            Console.WriteLine("Catnip = x, Mint = 0");
            Console.WriteLine();

            string exes = "x ";
            string ohs = "o ";
            Checkers(exes, ohs);
            Console.WriteLine();
            Rows(exes, ohs);

            Console.Read();
        }

        static void Checkers(string x, string o)
        {
            int z = 0;
            for (int ii = 0; ii < 5; ii++)
            {
                z++;
                for (int jj = 0; jj < 5; jj++)
                {
                    if ((jj + z) % 2 == 0)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(o);
                    }
                }
                Console.WriteLine();
            }
        }
        static void Rows(string x, string o)
        {
            for (int ii = 0; ii < 5; ii++)
            {
                for (int jj = 0; jj < 5; jj++)
                {
                    if (ii % 2 == 0)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(o);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

//nested-loops

//Josie Cat has 2 types of plants she would like to plant; cat nip, and mint.She would like to alternate each of these plants within 5 columns and 5 rows.

//If you have time, using the same number of colums and rows as above, create another garden for Josie Cat that has alternating rows

//The 1st/3rd/5th row are of Carrots
//The 2nd/4th row are of tomatos