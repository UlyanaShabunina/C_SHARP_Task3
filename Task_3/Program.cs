using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            float R = 0f; 
            float X = 0f; 
            float Y = 0f; 
 
            while (R <= 0)
            {
                Console.WriteLine("Введите значение R: ");
                R = Convert.ToSingle(Console.ReadLine());
            }
            Console.Write("Введите Х ");
            X = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите Y ");
            Y = Convert.ToSingle(Console.ReadLine());
            if (X >= -R && X <= R && Y <= R && Y >= -R)
            {
                if (X <= 0 && Y >= 0 && Math.Pow(X, 2) + Math.Pow(Y, 2) <= Math.Pow(R, 2))//krug
                {
                    Console.WriteLine("1Точка с координатами ({0};{1}) попала в закрашенную  область", X.ToString(), Y.ToString());
                }
                else if (X >= 0 && Y <= 0 && X <= R && Y >= -R)//treygolnik
                {
                    double tx1 = -(Y / 2);
                    double ty2 = -(X * 2);
                    double tx3 = (R + Y + 4) / 2;
                    double ty4 = 2 * (X - (R / 2)) - 4;
                    if (X <= R / 2 && Y >= -R && X <= tx1 && Y <= ty2)
                    {
                        Console.WriteLine("2Точка с координатами ({0};{1}) попала в закрашенную  область", X.ToString(), Y.ToString());
                    }
                    else if (X>=(R/2) && tx3>=X && ty4<=Y && Y>=-R)
                        {
                            Console.WriteLine("3Точка с координатами ({0};{1}) попала в закрашенную  область", X.ToString(), Y.ToString());
                        }
                        else
                        {
                            Console.WriteLine("1Точка с координатами ({0};{1}) не попала никуда.", X.ToString(), Y.ToString());
 
                        }
                }
            }
            else
            {
                Console.WriteLine("2Точка с координатами ({0};{1}) не попала никуда.", X.ToString(), Y.ToString());
            }
            Console.ReadKey();
 
        }
    }
}
