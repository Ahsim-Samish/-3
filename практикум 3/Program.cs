using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практикум_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*{
                int[] omas = new int[6];
                Random random = new Random();
                int max = omas[0];
                int indexmax = 0;
                for (int i = 0; i < omas.Length; i++)
                {
                    omas[i] = random.Next(-10, 10);
                    Console.WriteLine(omas[i]);
                }

                for (int i = 0; i < omas.Length; i++)
                {
                    if (omas[i] > max)
                    {
                        max = omas[i];
                        indexmax = i;
                    }
                }
                Console.WriteLine($"Наибольший элемент - {max}");
                Console.WriteLine($"Его номер - {indexmax}");
            }*/
            /*{
                int[] omas = new int[6];
                Random random = new Random();
                int max = omas[0];
                int indexmax = 0;
                int min = omas[0];
                int indexmin = 0;
                for (int i = 0; i < omas.Length; i++)
                {
                    omas[i] = random.Next(-10, 10);
                    Console.WriteLine(omas[i]);
                }

                for (int i = 0; i < omas.Length; i++)
                {
                    if (omas[i] > max)
                    {
                        max = omas[i];
                        indexmax = i;
                    }
                    if (omas[i] < min)
                    {
                        min = omas[i];
                        indexmin = i;
                    }
                }
                var b = omas[indexmax];
                omas[indexmax] = omas[indexmin];
                omas[indexmin] = b;
                max = omas[0];
                indexmax = 0;
                min = omas[0];
                indexmin = 0;
                for (int i = 0; i < omas.Length; i++)
                {
                    if (omas[i] > max)
                    {
                        max = omas[i];
                        indexmax = i;
                    }
                    if (omas[i] < min)
                    {
                        min = omas[i];
                        indexmin = i;
                    }
                }
                Console.WriteLine($"Наибольший элемент - {max}");
                Console.WriteLine($"Его номер - {indexmax}");
                Console.WriteLine($"Наименьший элемент - {min}");
                Console.WriteLine($"Его номер - {indexmin}");
            }*/
            /*{
                int[] omas = new int[6];
                Random random = new Random();
                int max = omas[0];
                int indexmax = 0;
                int min = omas[0];
                int indexmin = 0;
                for (int i = 0; i < omas.Length; i++)
                {
                    omas[i] = random.Next(-10, 10);
                    Console.WriteLine(omas[i]);
                }

                for (int i = 0; i < omas.Length; i++)
                {
                    if (omas[i] > max)
                    {
                        max = omas[i];
                        indexmax = i;
                    }
                    if (omas[i] < min)
                    {
                        min = omas[i];
                        indexmin = i;
                    }
                }
                var b = indexmax - indexmin;
                if (b<0)
                {
                    b = b * -1;
                }
                b--;
                Console.WriteLine($"Наибольший элемент - {max}");
                Console.WriteLine($"Его номер - {indexmax}");
                Console.WriteLine($"Наименьший элемент - {min}");
                Console.WriteLine($"Его номер - {indexmin}");
                Console.WriteLine($"Количество элементов, лежащих между максимальным и минимальным элементами - {b}");
            }*/
            /*{
                int[] omas = new int[6];
                Random random = new Random();
                int max = omas[0];
                int min = omas[0];
                for (int i = 0; i < omas.Length; i++)
                {
                    omas[i] = random.Next(-10, 10);
                    Console.WriteLine(omas[i]);
                }

                for (int i = 0; i < omas.Length; i++)
                {
                    if (omas[i] > max)
                    {
                        max = omas[i];
                    }
                    if (omas[i] < min)
                    {
                        min = omas[i];
                    }
                }
                for (int i = 0; i < omas.Length; i++)
                {
                    omas[i] += Math.Abs(max) + Math.Abs(min);
                    Console.WriteLine(omas[i]);
                }
            }*/
        }
    }
}
