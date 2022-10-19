// Задача со звёздочкой 1: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();
Console.WriteLine("Программа вычисляет функцию Аккермана с помощью рекурсии");

int first = 0;
first = AskForInput("первое");
int second = AskForInput("второе");

System.Console.WriteLine($"\nРезультат функции Аккермана для чисел {first} и {second} равна = {AkkerFunction(first, second)}");


//////////////////////////// функции ////////////////////////////////////////////////////


int AskForInput(string str)
{
    while (true)
    {
        Console.Write($"\nНапишите {str} положительное число:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number >= 0) 
            {
                return number;
                break;
            }
            else Console.WriteLine($"Некорректно указано {str} положительное число!\n");
        }
        else Console.WriteLine($"Некорректно указано {str} положительное число!\n");
    }
}

int AkkerFunction(int first, int second)
{
    if(first == 0) return second + 1;
    else if(first != 0 && second == 0) return AkkerFunction(first - 1, 1);
    else return AkkerFunction(first - 1, AkkerFunction(first, second - 1));    
}