// Задание 1

using System.Globalization;

Console.Write("Введите пароль первый раз: ");
string pass1 = Console.ReadLine();
Console.Write("Введите пароль второй раз: ");
string pass2 = Console.ReadLine();
if (pass1 == pass2)
{
    Console.WriteLine("Пароль принят");
}
else
{
    Console.WriteLine("Пароль не принят");
}

Console.WriteLine("");
// Задание 2

Console.Write("Введите ваш возраст: ");
int age = int.Parse(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ запрещён");
    Console.WriteLine("");
}

Console.WriteLine("");
// Задание 3

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Выбор операции:");
Console.WriteLine("1. Сложение");
Console.WriteLine("2. Вычитание");
Console.WriteLine("3. Умножение");
Console.WriteLine("4. Деление");
Console.Write("Выберите пункт (1-4): ");
string choice = Console.ReadLine();
switch (choice)
{
    case "1":
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;
    case "2":
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        break;
    case "3":
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;
    case "4":
        if (num2 != 0)
        {
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        } else
        {
            Console.WriteLine($"Ошибка, деление на 0 запрещено!");
        } break;
    default: {
        Console.WriteLine($"Ошибка, выбрана неверная операция");
    } break;
}

Console.WriteLine("");
// Задание 4

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
int sum = 0;
if (number1 >= 0)
{
    sum += number1;
}
if (number2 >= 0)
{
    sum += number2;
}
if (number3 >= 0)
{
    sum += number3;
}
Console.WriteLine($"Сумма положительных чисел из этих трёх = {sum}");

Console.WriteLine("");
//Задание 5
Console.WriteLine("Вы стоите перед первой дверью. Перед вами два пути:");
Console.WriteLine("Путь А: Войти в комнату с огромным драконом");
Console.WriteLine("Путь B: Пойти по тёмному коридору");
Console.WriteLine("");
Console.Write("Выберите по какому пути идёте (A или B): ");
string door1 = Console.ReadLine();
switch(door1)
{
    case "A" :
        {
            Console.WriteLine("Дракон говорит: Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.");
            Console.WriteLine("");
            Console.Write("Введите ответ на загадку: ");
            string answer = Console.ReadLine();
            if (answer == "рыба")
            {
                Console.WriteLine("");
                Console.WriteLine("Вы попали в следующую комнату");
            } else
            {
                Console.WriteLine("");
                Console.WriteLine("Вы погибли! Вас съел дракон");
            }
        } break;
    case "B":
        {
            Console.Write("Перед вами 2 двери. Выберите 1 или 2: ");
            string door2 = Console.ReadLine();
            switch (door2)
            {
                case "1":
                    {
                        Console.WriteLine("Вы нашли сокровища Dungeon Master’а!");
                    } break;
                case "2":
                    {
                        Console.WriteLine("Вы попали на ловушку с ядовитыми шипами!");
                    } break;
                default :
                    {
                        Console.WriteLine("Такого выбора нет!");
                    } break;
            }
        } break;
    default :
        {
            Console.WriteLine("Такого выбора нет!");
        } break;
}