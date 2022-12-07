// Задача №17. Напишите программу, которая принимает на вход 
//координаты точки (X и Y),причем X ≠ 0 и Y ≠ 0 и 
//выдаёт номер четверти плоскости, в которой находится эта точка.


/*
   1. reference types(ссылочные типы) - class, char, arrays, list
   2. valur types(значимые типы) - int, long, doble, detetime, struct, enum, decimal
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    /* Проверка, что число не является нулём,
    если числа введены корректно,то isCorrect принимает значение true, и выходить из тела*/
    while (!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result != 0) 
        // TryParse безопасное преобразование из типа string в переменную int
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Введи некорректное число");
        }
    }

    return result;
}
// тут GetQuarter проверяет к какой плоскости относиться числа
int GetQuarter(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    if(x < 0 && y > 0)
        return 2;
    if(x < 0 && y < 0)
        return 3;
    
    return 4;
}

int x = GetNumber("Введите координату x: ");
int y = GetNumber("Введите координату y: ");
int quarter = GetQuarter(x,y);

Console.WriteLine($"Точка с координатами ({x}, {y}) лежат в {quarter} четверти");