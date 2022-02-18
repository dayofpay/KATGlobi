using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatGlobi
{
    class Program
    {
        public static int placeType
        {
            get;
            set;
        }
        public static int speedLimit
        {
            get;
            set;
        }
        public static int mySpeed
        {
            get;
            set;
        }
        static void Main(string[] args)
        {
        Restart:
            try
            {
                Console.Title = "Изчисляване на глоби в КАТ / https://github.com/dayofpay";
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("[1] Населено място");
                Console.WriteLine("[2] Извън населено място");
                Console.WriteLine();
                Console.Write(">");
                placeType = int.Parse(Console.ReadLine());
                if (placeType > 2)
                {
                    goto Restart;
                }
                Console.Clear();
                Console.Write("Ограничение: ");
                speedLimit = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.Write("Вашата скорост: ");
                mySpeed = int.Parse(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Изглежда, че програмата върна грешка :( : [{error.Message}]");
                System.Threading.Thread.Sleep(2000);
                goto Restart;
            }
            if (placeType == 1 && speedLimit - mySpeed < 0)
            {
                try
                {
                    int realNumber = Math.Abs(mySpeed - speedLimit);
                    if (Math.Abs(mySpeed - speedLimit) == 10)
                    {
                        Console.WriteLine("Превишили сте скороста с 10 КМ, което се равнява на 20 ЛВ Глоба !");
                    }
                    else if (Math.Abs(mySpeed - speedLimit) >= 11 && (Math.Abs(mySpeed - speedLimit) <= 20))
                    {
                        Console.WriteLine($"Превишили сте скороста с {Math.Abs(mySpeed - speedLimit)} КМ, което се равнява на 50 ЛВ Глоба !");
                    }
                    else if (Math.Abs(mySpeed - speedLimit) >= 21 && (Math.Abs(mySpeed - speedLimit) <= 30))
                    {
                        Console.WriteLine($"Превишили сте скороста с {Math.Abs(mySpeed - speedLimit)} КМ, което се равнява на 100 ЛВ Глоба !");
                    }
                    else if (Math.Abs(mySpeed - speedLimit) >= 31 && (Math.Abs(mySpeed - speedLimit) <= 40))
                    {
                        Console.WriteLine($"Превишили сте скороста с {Math.Abs(mySpeed - speedLimit)} КМ, което се равнява на 400 ЛВ Глоба !");
                    }
                    else if (Math.Abs(mySpeed - speedLimit) >= 41 && (Math.Abs(mySpeed - speedLimit) <= 49))
                    {
                        Console.WriteLine($"Превишили сте скороста с {Math.Abs(mySpeed - speedLimit)} КМ, което се равнява на 600 ЛВ Глоба !");
                    }
                    else if (Math.Abs(mySpeed - speedLimit) >= 50 && Math.Abs(mySpeed - speedLimit) <= 54)
                    {
                        Console.WriteLine($"Превишили сте скороста с {Math.Abs(mySpeed - speedLimit)} КМ, което се равнява на 700 ЛВ Глоба !");
                    }
                    else if (Math.Abs(mySpeed - speedLimit) >= 54)
                    {
                        var n = (mySpeed - speedLimit - 50) / 5; // N > ( Моята скорост - Ограничение ) - Ограничение разделено на 5 > По този начин получаваме степента на остатъка от изваждането на скороста
                        Console.WriteLine($"Превишили сте скороста с {(Math.Abs(mySpeed - speedLimit))} КМ, което се равнява на {n * 50 + 700} ЛВ Глоба !");

                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("> Натиснете бутона 'R' за да рестартирате програмата !");
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.R)
                    {
                        goto Restart;
                    }
                } catch (Exception error)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Изглежда, че програмата върна грешка :( : [{error.Message}]");
                    System.Threading.Thread.Sleep(2000);
                    goto Restart;
                }
            }
            if (placeType == 2 && speedLimit - mySpeed < 0)
            {
                try
                {
                    int realNumber = Math.Abs(speedLimit - mySpeed);
                    if (Math.Abs(speedLimit - mySpeed) == 10)
                    {
                        Console.WriteLine("Превишили сте скороста с 10 КМ, което се равнява на 20 ЛВ Глоба !");
                    }
                    else if (Math.Abs(speedLimit - mySpeed) >= 11 && (Math.Abs(speedLimit - mySpeed) <= 20))
                    {
                        Console.WriteLine($"Превишили сте скороста с {Math.Abs(speedLimit - mySpeed)} КМ, което се равнява на 50 ЛВ Глоба !");
                    }
                    else if (Math.Abs(speedLimit - mySpeed) >= 21 && (Math.Abs(speedLimit - mySpeed) <= 30))
                    {
                        Console.WriteLine($"Превишили сте скороста с {Math.Abs(speedLimit - mySpeed)} КМ, което се равнява на 100 ЛВ Глоба !");
                    }
                    else if (Math.Abs(speedLimit - mySpeed) >= 31 && (Math.Abs(speedLimit - mySpeed) <= 40))
                    {
                        Console.WriteLine($"Превишили сте скороста с {Math.Abs(speedLimit - mySpeed)} КМ, което се равнява на 300 ЛВ Глоба !");
                    }
                    else if (Math.Abs(speedLimit - mySpeed) >= 41 && (Math.Abs(speedLimit - mySpeed) <= 49))
                    {
                        Console.WriteLine($"Превишили сте скороста с {Math.Abs(speedLimit - mySpeed)} КМ, което се равнява на 400 ЛВ Глоба !");
                    }
                    else if (Math.Abs(speedLimit - mySpeed) >= 50 && Math.Abs(speedLimit - mySpeed) <= 54)
                    {
                        Console.WriteLine($"Превишили сте скороста с {Math.Abs(speedLimit - mySpeed)} КМ, което се равнява на 600 ЛВ Глоба !");
                    }
                    else if (Math.Abs(speedLimit - mySpeed) >= 54)
                    {
                        var n = (mySpeed - speedLimit - 50) / 5; // N > ( Моята скорост - Ограничение ) - Ограничение разделено на 5 > По този начин получаваме степента на остатъка от изваждането на скороста
                        Console.WriteLine($"Превишили сте скороста с {(Math.Abs(speedLimit - mySpeed))} КМ, което се равнява на {n * 50 + 700} ЛВ Глоба !");

                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("> Натиснете бутона 'R' за да рестартирате програмата !");
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.R)
                    {
                        goto Restart;
                    }
                }
                catch (Exception error)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Изглежда, че програмата върна грешка :( : [{error.Message}]");
                    System.Threading.Thread.Sleep(2000);
                    goto Restart;
                }
            }
            else
            {
                Console.WriteLine($"Не сте в нарушение, тъй като вашата скорост е със {speedLimit - mySpeed} KM/H под ограничената такава скорост !");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("> Натиснете бутона 'R' за да рестартирате програмата !");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.R)
                {
                    goto Restart;
                }
            }
        } // TODO: 
        // Всичко замислено е приключено .... 
        }
    }
