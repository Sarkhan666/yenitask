using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            static int Tasks(int sayi1, int sayi2, int sayi3)
            {
                int result = 0;
                if (sayi1 > sayi2 && sayi1 > sayi3)
                {
                    Console.WriteLine(sayi1);
                    result = sayi1;

                }
                else if (sayi2 > sayi1 && sayi2 > sayi3)
                {
                    Console.WriteLine(sayi2);
                    result = sayi2;
                }
                else if (sayi3 > sayi1 && sayi3 > sayi2)
                {
                    Console.WriteLine(sayi3);
                    result = sayi3;
                }
                return result;







            }
            static int tasks(int sayi1, int sayi2, int sayi3, int sayi4)
            {
                int code = tasks(sayi1, sayi2, sayi3);
                int result = 0;
                if (code > sayi4)
                {
                    Console.WriteLine(code);
                    result = code;
                }
                else
                {
                    result = sayi4;
                    Console.WriteLine(result);

                }
                return result;


                static int tasks(int sayi1, int sayi2, int sayi3, int sayi4, int sayi5)
                {
                    int code1 = tasks(sayi1, sayi2, sayi3, sayi4);
                    int result = 0;
                    if (code1 > sayi5)
                    {
                        Console.WriteLine(code1);
                        result = code1;
                    }
                    else
                    {
                        result = sayi5;
                        Console.WriteLine(result);
                    }
                    return result;
                }

            }
        }
}
