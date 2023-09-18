Console.WriteLine("Выберите операцию:\n1. Сложить 2 числа\n2. Вычесть первое из второго\n3. Перемножить два числа\n4. Разделить первое на второе\n5. Возвести в степень N первое число\n6. Найти квадратный корень из числа\n7. Найти 1 процент от числа\n8. Найти факториал из числа\n9. Выйти из программы");
string x = Console.ReadLine();
int operation = Convert.ToInt32(x);
while (operation != 9) // общий цикл для всех оппераций
{
    if (operation <= 4)
    {
        do //цикл с двумя вводимыми числами (операции с 1 по 4 включительно)
        {
            Console.WriteLine("Введите первое число:");
            string num1 = Console.ReadLine();
            int a = Convert.ToInt32(num1);
            Console.WriteLine("Введите второе число:");
            string num2 = Console.ReadLine();
            int b = Convert.ToInt32(num2);

            if (operation == 1)
            {
                int res = a + b;
                Console.WriteLine("Результат: " + res);
                Console.WriteLine("Выберите операцию еще раз:");
                string op = Console.ReadLine();
                operation = Convert.ToInt32(op);

            }

            else if (operation == 2)
            {
                int res = b - a;
                Console.WriteLine("Результат: " + res);
                Console.WriteLine("Выберите операцию еще раз:");
                string op = Console.ReadLine();
                operation = Convert.ToInt32(op);
            }

            else if (operation == 3)
            {
                int res = a * b;
                Console.WriteLine("Результат: " + res);
                Console.WriteLine("Выберите операцию еще раз:");
                string op = Console.ReadLine();
                operation = Convert.ToInt32(op);
            }

            else if (operation == 4)
            {
                int res = a / b;
                Console.WriteLine("Результат: " + res);
                Console.WriteLine("Выберите операцию еще раз:");
                string op = Console.ReadLine();
                operation = Convert.ToInt32(op);
            }

        } while (operation <= 4);
    }
    else if (operation > 4)
    {
        do // цикл с одной переменной или степень (с 5 по 8)
        {
            if (operation == 5)
            {
                Console.WriteLine("Введите число:");
                string num1 = Console.ReadLine();
                int a = Convert.ToInt32(num1);
                Console.WriteLine("Введите степень числа:");
                string num2 = Console.ReadLine();
                int b = Convert.ToInt32(num2);
                double res = Math.Pow(a, b);
                Console.WriteLine("Результат: " + res);
                Console.WriteLine("Выберите операцию еще раз:");
                string op = Console.ReadLine();
                operation = Convert.ToInt32(op);
            }
            else if (operation == 6)
            {
                Console.WriteLine("Введите число:");
                string num1 = Console.ReadLine();
                int a = Convert.ToInt32(num1);
                double res = Math.Sqrt(a);
                Console.WriteLine("Результат: " + res);
                Console.WriteLine("Выберите операцию еще раз:");
                string op = Console.ReadLine();
                operation = Convert.ToInt32(op);
            }
            else if (operation == 7)
            {
                Console.WriteLine("Введите число:");
                string num1 = Console.ReadLine();
                float a = Convert.ToInt32(num1);
                double res = (a / 100) * 1;
                Console.WriteLine("Результат: " + res);
                Console.WriteLine("Выберите операцию еще раз:");
                string op = Console.ReadLine();
                operation = Convert.ToInt32(op);
            }
            else if (operation == 8)
            {
                Console.WriteLine("Введите число:");
                string num1 = Console.ReadLine();
                float a = Convert.ToInt32(num1);
                int res = 1;
                for (int i = 1; i <= a; i++) res = res * i;
                Console.WriteLine("Результат: " + res);
                Console.WriteLine("Выберите операцию еще раз:");
                string op = Console.ReadLine();
                operation = Convert.ToInt32(op);
            }
        } while (operation > 4);
    }
}