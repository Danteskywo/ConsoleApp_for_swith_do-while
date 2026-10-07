//Console.WriteLine("Начало итерации");
//Console.WriteLine("Введите число от 0 до 10 и мы выведем последовательность по возрастанию до 10!");
//int firstNum = Convert.ToInt32(Console.ReadLine());

//for (int i = firstNum; i <= 10; i++)
//{
//    Console.WriteLine($"Текущее значение: {i}");
//}
//Console.WriteLine("Цикл завершен");

//for (int i = 1; i <= 100; i++)
//{
//    Console.WriteLine($"Проверяем число {i}...");
//    if (i % 7 == 0) // Если остаток от деления на 7 равен 0
//    {
//        Console.WriteLine($"Найдено! Первое число, делящееся на 7, это {i}.");
//        break; // Выходим из цикла, дальнейшие проверки не нужны
//    }
//}


//for (int i = 1; i <= 10; i++)
//{
//    if (i % 2 == 0) // Если число четное...
//    {
//        continue; // ...пропускаем остаток тела цикла (Console.WriteLine) и идем к следующему i
//    }
//    Console.WriteLine(i);
//}


//int firstNum;
//while (true)
//{
//    Console.WriteLine("Введите число от 0 доя 10");
//    int input = Convert.ToInt32(Console.ReadLine());

//    if (input <= 0)
//    {
//        Console.WriteLine("Число не может быть отрицательным или нулём!");
//    }
//    else if (input > 10)
//    {
//        Console.WriteLine("Число не может быть более 10");
//    }
//    else
//    {
//        firstNum = input;
//        break;
//    }
//}
//for (int i = firstNum; i <= 10; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine($"Текущее значение {i}");
//    }
//}
//Console.WriteLine("Завершение итерации");



//Console.WriteLine("ВВедите пароль и повторите!");
//string userPassword = Convert.ToString(Console.ReadLine());
//string userInput = "    ";

//Console.WriteLine("Введите пароль");
//while (userInput != userPassword)
//{
//    Console.WriteLine("Попытка: ");
//    userInput = Console.ReadLine();

//    if (userInput != userPassword)
//    {
//        Console.WriteLine("Неверный пароль!");
//    }
//}
//Console.WriteLine($"Пароль принят {userInput}. Доступ разрешен! ");




//string userChoice;

//do
//{
//    Console.WriteLine("\n -- Главное меню --");
//    Console.WriteLine("1. Вход в меню");
//    Console.WriteLine("2.Сохранение игры!");
//    Console.WriteLine("3.Загрузить игру");
//    Console.WriteLine("4.Выход из игры");

//    userChoice = Console.ReadLine();
//} while (userChoice != "4");
//Console.WriteLine("Спасибо за игру!");


//while (true)
//{
//    Console.WriteLine("\n -- Главное меню --");
//    Console.WriteLine("1. Вход в меню");
//    Console.WriteLine("2.Сохранение игры!");
//    Console.WriteLine("3.Загрузить игру");
//    Console.WriteLine("4.Выход из игры");

//    int userChoice = Convert.ToInt16(Console.ReadLine());

//    if (userChoice == 4)
//    {
//        Console.WriteLine("Выход из игры!");
//        break;
//    }
//    else if (userChoice >= 5 || userChoice <= 0)
//    {
//        Console.WriteLine("Не верная команда!");
//    }

//    switch (userChoice)
//    {
//        case 1: Console.WriteLine("Вы вошли в меню!"); break;
//        case 2: Console.WriteLine("Вы сохранили игшру!"); break;
//        case 3: Console.WriteLine("Вы загрузили игру!"); break;
//        default: Console.WriteLine("Неверный пункт!"); break;
//    }
//}
//Console.WriteLine("Конец программы!");




//Console.WriteLine("=== Калькулятор на if ===");
//Console.Write("Введите первое число: ");
//double a = Convert.ToDouble(Console.ReadLine());

//Console.Write("Введите оператор (+, -, *, /): ");
//string op = Console.ReadLine();

//Console.Write("Введите второе число: ");
//double b = Convert.ToDouble(Console.ReadLine());

//double result;

//if (op == "+")
//{
//    result = a + b;
//    Console.WriteLine($"{a} + {b} = {result}");
//}
//else if (op == "-")
//{
//    result = a - b;
//    Console.WriteLine($"{a} - {b} = {result}");
//}
//else if (op == "*")
//{
//    result = a * b;
//    Console.WriteLine($"{a} * {b} = {result}");
//}
//else if (op == "/")
//{
//    if (b == 0)
//    {
//        Console.WriteLine("Ошибка: деление на ноль!");
//    }
//    else
//    {
//        result = a / b;
//        Console.WriteLine($"{a} / {b} = {result}");
//    }
//}
//else
//{
//    Console.WriteLine("Неизвестный оператор!");
//}



Console.WriteLine("=== Калькулятор на switch ===");
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите оператор (+, -, *, /): ");
string op = Console.ReadLine();

Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

switch (op)
{
    case "+":
        Console.WriteLine($"{a} + {b} = {a + b}");
        break;
    case "-":
        Console.WriteLine($"{a} - {b} = {a - b}");
        break;
    case "*":
        Console.WriteLine($"{a} * {b} = {a * b}");
        break;
    case "/":
        if (b == 0)
            Console.WriteLine("Ошибка: деление на ноль!");
        else
            Console.WriteLine($"{a} / {b} = {a / b}");
        break;
    default:
        Console.WriteLine("Неизвестный оператор!");
        break;
}


//// Попвтка допушить проект (добавил пару строк)
///Добавил еще одну строку ! 