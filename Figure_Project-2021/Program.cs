using System;

namespace Figure_Project_2021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Input();

            if (figure.ToLower() == "кръг" || figure.ToLower() == "circle")
            {
                Circle();
            }
            else if (figure.ToLower() == "квадрат" || figure.ToLower() == "square")
            {
                Square();
            }
            else if (figure.ToLower() == "триъгълник" || figure.ToLower() == "triangle")
            {
                Triangle();
            }
            else if (figure.ToLower() == "шестоъгълник" || figure.ToLower() == "hexagon")
            {
                Hexagon();
            }
            else if (figure.ToLower() == "трапец" || figure.ToLower() == "trapezoid")
            {
                Trapezoid();
            }
            else if (figure.ToLower() == "ромб" || figure.ToLower() == "rhombus")
            {
                Rhombus();
            }
        }

        private static string Input()
        {
            Console.WriteLine();
            Console.WriteLine("Налични фигури:");
            Console.WriteLine("> Кръг     > Квадрат     > Триъгълник     > Шестоъгълник     > Трапец     > Ромб");

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();


            Console.Write("Напишете фигурата, която искате да принтриате: ");
            string figure = Console.ReadLine();
            return figure;
        }

        private static void Rhombus()
        {
            int i, j, count = 1, number;
            Console.Write("Въведете дължината на страната на ромба: ");
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            Console.WriteLine();
            for (j = 1; j <= number; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (j = 1; j <= number - 1; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - j) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        private static void Trapezoid()
        {
            Console.Write("Въведете височината на трапеца: ");
            int k = int.Parse(Console.ReadLine());

            while (k <= 0)
            {
                Console.WriteLine("Височината на трапеца не може да е отрицателно или равно на 0 число!");
                Console.Write("Въведете правилна височината на трапеца: ");
                k = int.Parse(Console.ReadLine());
            }
            int count = k;

            Console.Write("Въведете дължината на малката основа на трапеца: ");
            int d = int.Parse(Console.ReadLine());

            while (d <= 0)
            {
                Console.WriteLine("Дължината на малката основа на трапеца не може да е отрицателно или равно на 0 число!");
                Console.Write("Въведете правилна дължината на малката основа на трапеца: ");
                d = int.Parse(Console.ReadLine());
            }


            Console.WriteLine();

            for (int i = 0; i < int.MaxValue; i++)
            {

                for (int l = k; l > 1; l--)
                {
                    Console.Write("  ");
                }

                for (int j = 0; j < d; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                k--;
                d = d + 4;

                if (i + 1 == count)
                {
                    return;
                }
            }

            Console.WriteLine();
        }

        private static void Hexagon()
        {
            Console.Write("Добре, сега въведете височината на шестоъгълника: ");
            int N = int.Parse(Console.ReadLine());

            while (N <= 0)
            {
                Console.WriteLine("Височината не може да е отрицателно или равно на 0 число!");
                Console.Write("Въведете правилна височина: ");
                N = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("> Празен шестоъгълник: ");
            int EntireWidth = N * 2 + 1;
            int Height = 6 + ((N - 3) / 2) * 3;
            int SailsHeight = (Height / 3) * 2;
            int baseOfBoat = Height / 3;
            int newN = N;

            newN = N;
            int LastCalculation = (EntireWidth - newN) / 2;
            Console.Write(new string(' ', LastCalculation));
            Console.Write(new string('*', newN));
            Console.Write(new string(' ', LastCalculation));

            for (int i = baseOfBoat - 1; i > 0; i--)
            {
                Console.Write(new string(' ', i + 1));
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', (EntireWidth - 3 - (2 * i + 1)) / 2));
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', (EntireWidth - 3 - (2 * i + 1)) / 2));
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', i + 1));
                Console.WriteLine();
            }

            newN = N;
            for (int i = 0; i < baseOfBoat - 1; i++)
            {
                Console.Write(new string(' ', i + 1));
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', (EntireWidth - 3 - (2 * i + 1)) / 2));
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', (EntireWidth - 3 - (2 * i + 1)) / 2));
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', i + 1));
                Console.WriteLine();
            }



            newN = N;
            LastCalculation = (EntireWidth - newN) / 2;
            Console.Write(new string(' ', LastCalculation));
            Console.Write(new string('*', newN));
            Console.Write(new string(' ', LastCalculation));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("> Запълнен шестоъгълник: ");

            newN = N;
            LastCalculation = (EntireWidth - newN) / 2;
            Console.Write(new string(' ', LastCalculation));
            Console.Write(new string('*', newN));
            Console.Write(new string(' ', LastCalculation));

            for (int i = baseOfBoat - 1; i > 0; i--)
            {
                Console.Write(new string(' ', i + 1));
                Console.Write(new string('*', 1));
                Console.Write(new string('*', (EntireWidth - 3 - (2 * i + 1)) / 2));
                Console.Write(new string('*', 1));
                Console.Write(new string('*', (EntireWidth - 3 - (2 * i + 1)) / 2));
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', i + 1));
                Console.WriteLine();
            }

            newN = N;
            for (int i = 0; i < baseOfBoat - 1; i++)
            {
                Console.Write(new string(' ', i + 1));
                Console.Write(new string('*', 1));
                Console.Write(new string('*', (EntireWidth - 3 - (2 * i + 1)) / 2));
                Console.Write(new string('*', 1));
                Console.Write(new string('*', (EntireWidth - 3 - (2 * i + 1)) / 2));
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', i + 1));
                Console.WriteLine();
            }

            newN = N;
            LastCalculation = (EntireWidth - newN) / 2;
            Console.Write(new string(' ', LastCalculation));
            Console.Write(new string('*', newN));
            Console.Write(new string(' ', LastCalculation));
        }

        private static void Triangle()
        {
            int b = 0;
            double i, j, count = 1;
            double a;
            Console.Write("Въведете вида на триъгълника. Възможните видове са равнобедрен, равностранен и правоъгълен. ");
            string typeOfTriangle = Console.ReadLine();

            if (typeOfTriangle == "равнобедрен" || typeOfTriangle == "Равнобедрен")
            {
                Console.Write("Въведете дължината на бедрото триъгълника: ");
                a = double.Parse(Console.ReadLine());

                while (a <= 0)
                {
                    Console.WriteLine("Дължината на триъгълника не може да е отрицателно или равно на 0 число!");
                    Console.Write("Въведете правилна дължина на бедрото: ");
                    a = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();

                Console.WriteLine("> Запълнен триъгълник: ");
                double c = a;
                count = a - 1;
                for (j = 1; j <= a; j++)
                {
                    for (i = 1; i <= count; i++)
                        Console.Write(" ");
                    count--;
                    for (i = 1; i <= 2 * j - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("> Празен триъгълник: ");
                count = 1;
                count = c - 1;
                for (j = 1; j <= c; j++)
                {
                    for (i = 1; i <= count; i++)
                        Console.Write(" ");
                    count--;
                    for (i = 1; i <= 2 * j - 1; i++)
                        if (i == 1 || i == 2 * j - 1)
                        {
                            Console.Write("*");
                        }
                        else if (j == a)
                        {
                            Console.Write(" *");
                            b++;
                            if (b == a - 1)
                            {
                                return;
                            }
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }

            else if (typeOfTriangle == "равностранен" || typeOfTriangle == "Равностранен")
            {
                Console.Write("Въведете дължината на страната на триъгълника: ");
                a = double.Parse(Console.ReadLine());

                while (a <= 0)
                {
                    Console.WriteLine("Дължината на триъгълника не може да е отрицателно или равно на 0 число!");
                    Console.Write("Въведете правилна дължина на страната: ");
                    a = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();

                Console.WriteLine("> Запълнен триъгълник: ");
                double c = a;
                count = a - 1;
                double count1 = a;

                for (j = 1; j <= a; j++)
                {
                    for (i = 1; i <= count; i++)
                        Console.Write(" ");
                    count--;
                    for (i = 1; i <= 2 * j - 1; i++)
                        if (j == a)
                        {
                            Console.Write("* ");
                            count1--;
                            if (count1 == count1 / 2)
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.Write("*");
                        }

                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("> Празен триъгълник: ");
                count = 1;
                count = c - 1;
                for (j = 1; j <= c; j++)
                {
                    for (i = 1; i <= count; i++)
                        Console.Write(" ");
                    count--;
                    for (i = 1; i <= 2 * j - 1; i++)
                        if (i == 1 || i == 2 * j - 1)
                        {
                            Console.Write("*");
                        }
                        else if (j == a)
                        {
                            Console.Write(" *");
                            b++;
                            if (b == a - 1)
                            {
                                return;
                            }
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }

            else if (typeOfTriangle == "правоъгълен" || typeOfTriangle == "Правоъгълен")
            {
                Console.Write("Въведете дължината на страната на триъгълника: ");
                a = double.Parse(Console.ReadLine());

                while (a <= 0)
                {
                    Console.WriteLine("Дължината на триъгълника не може да е отрицателно или равно на 0 число!");
                    Console.Write("Въведете правилна дължина на страната: ");
                    a = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();

                Console.WriteLine("> Запълнен триъгълник: ");
                double c = a;
                count = a - 1;
                double count1 = a;

                for (j = 1; j <= c; j++)
                {
                    for (i = 1; i <= count; i++)
                        Console.Write("  ");
                    count--;
                    for (i = 1; i <= 2 * j - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }


                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("> Празен триъгълник: ");
                count = 1;
                count = c - 1;
                for (j = 1; j <= c; j++)
                {
                    for (i = 1; i <= count; i++)
                        Console.Write("  ");
                    count--;
                    for (i = 1; i <= 2 * j - 1; i++)
                        if (i == 1 || i == 2 * j - 1 || j == a)
                        {
                            Console.Write("*");
                        }

                        else
                        {
                            Console.Write(" ");
                        }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Невалиден вид на триъгълника.");
            }
        }

        private static void Square()
        {
            double a;
            Console.Write("Въведете дължина на квадрата: ");
            a = double.Parse(Console.ReadLine());

            while (a <= 0)
            {
                Console.Write("Дължината на квадрата не може да е отрицателно или равно на 0 число! Моля въведете правилна дължина: ");
                a = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Празен квадрат: ");
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    if ((i != 1) && (i != a) && (j != 1) && (j != a))
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Запълнен квадрат: ");
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        private static void Circle()
        {
            double r;
            double t = 0.4;
            char s = '*';

            Console.Write("Добре, сега въведете радиус: ");
            r = double.Parse(Console.ReadLine());

            while (r <= 0)
            {
                Console.Write("Радиусът не може да е отрицателно или равно на 0 число! Моля въведете правилен радиус: ");
                r = double.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            double rIn = r - t, rOut = r + t;
            for (double y = r; y >= -r; --y)
            {
                for (double x = -r; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(s);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
