using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberReader
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Wpisz liczbę całkowitą od 1 do 1000");
            string input = Console.ReadLine();
            int a;
            if (Int32.TryParse(input, out a))

            {

                if (a > 1000) { Console.Write("Wypchaj się, miało być do 1000!"); }
                else
                {
                    if (a == 1000) { a -= 1000; Console.Write("Tysiąc "); }


                    if (a >= 900) { a -= 900; Console.Write("dziewięćset "); }
                    else if (a >= 800) { a -= 800; Console.Write("osiemset "); }
                    else if (a >= 700) { a -= 700; Console.Write("siedemset "); }
                    else if (a >= 600) { a -= 600; Console.Write("sześćset "); }
                    else if (a >= 500) { a -= 500; Console.Write("pięćset "); }
                    else if (a >= 400) { a -= 400; Console.Write("czterysta "); }
                    else if (a >= 300) { a -= 300; Console.Write("trzysta "); }
                    else if (a >= 200) { a -= 200; Console.Write("dwieście "); }
                    else if (a >= 100) { a -= 100; Console.Write("sto "); }

                    if (a >= 90) { a -= 90; Console.Write("dziewięćdziesiąt "); }
                    else if (a >= 80) { a -= 80; Console.Write("osiemdziesiąt "); }
                    else if (a >= 70) { a -= 70; Console.Write("siedemdziesiąt "); }
                    else if (a >= 60) { a -= 60; Console.Write("sześćdziesiąt "); }
                    else if (a >= 50) { a -= 50; Console.Write("pięćdziesiąt "); }
                    else if (a >= 40) { a -= 40; Console.Write("czterdzieści "); }
                    else if (a >= 30) { a -= 30; Console.Write("trzydzieści "); }
                    else if (a >= 20) { a -= 20; Console.Write("dwadzieścia "); }


                    switch (a)
                    {
                        case 1: Console.Write("jeden"); break;
                        case 2: Console.Write("dwa"); break;
                        case 3: Console.Write("trzy"); break;
                        case 4: Console.Write("cztery"); break;
                        case 5: Console.Write("pięć"); break;
                        case 6: Console.Write("szcześć"); break;
                        case 7: Console.Write("siedem"); break;
                        case 8: Console.Write("osiem"); break;
                        case 9: Console.Write("dziewięć"); break;
                        case 10: Console.Write("dziesięć"); break;
                        case 11: Console.Write("jedenaście"); break;
                        case 12: Console.Write("dwanaście"); break;
                        case 13: Console.Write("trzynaście"); break;
                        case 14: Console.Write("czternaście"); break;
                        case 15: Console.Write("piętnaście"); break;
                        case 16: Console.Write("szesnaście"); break;
                        case 17: Console.Write("siedemnaście"); break;
                        case 18: Console.Write("osiemnaście"); break;
                        case 19: Console.Write("dziewiętnaście"); break;
                        default: Console.Write(""); break;
                    }
                }

            }
            else { Console.WriteLine("{0} nie jest liczbą!", input); }


            Console.ReadKey();

        }
    }
}