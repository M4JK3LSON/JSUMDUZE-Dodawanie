using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSUMDUZE___Dodawanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                string dane = Console.ReadLine();
                string[] dates = dane.Split(' ');
                int[] liczniki = new int[3];
                int[] mianowniki = new int[3];
                int b = 0;

                foreach (string item in dates)
                {
                  string[] a = item.Split('/');
                    liczniki[b] = int.Parse(a[0]);
                    mianowniki[b] = int.Parse(a[1]);
                    b++;
                }

               
               // int wspolny = 0;

                int[] ujednoliconeliczniki = new int[3];
                int[] ujednoliconemianowniki = new int[3];


                for (int j = 1; ; j++)
                {
                    if (j % mianowniki[0] == 0 && j % mianowniki[1] == 0 && j % mianowniki[2] == 0)
                    {
                       // wspolny = j;
                        ujednoliconeliczniki[0] = liczniki[0] * (j / mianowniki[0]);
                        ujednoliconeliczniki[1] = liczniki[1] * (j / mianowniki[1]);
                        ujednoliconeliczniki[2] = liczniki[2] * (j / mianowniki[2]);
                        mianowniki[0] = j;
                        mianowniki[1] = j;
                        mianowniki[2] = j;

                        break;
                    }
                }

                    if ((ujednoliconeliczniki[0] + ujednoliconeliczniki[1] > ujednoliconeliczniki[2]) && (ujednoliconeliczniki[0] + ujednoliconeliczniki[2] > ujednoliconeliczniki[1]) && (ujednoliconeliczniki[1] + ujednoliconeliczniki[2] > ujednoliconeliczniki[0]))
                    {
                        Console.WriteLine("TAK");
                    }
                    else
                    {
                        Console.WriteLine("NIE");
                    }
                
                

                

                
            }
            Console.ReadKey();
        }
    }
}
