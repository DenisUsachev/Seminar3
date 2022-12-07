/*Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).*/

//Нахождение через метод switch
string Method(int quarter)
{
    switch(quarter)
    {
        case 1:
            return"x = 0 ... ∞ \ny = 0 ... ∞";
            break;
        case 2:
            return"x = 0 ... -∞ \ny = 0 ... ∞";
            break;
        case 3:
            return"x = 0 ... -∞ \ny = 0 ... -∞";
            break;
        case 4:
            return"x = 0 ... ∞ \ny = 0 ... -∞";
            break;
        default:
            return "Нужно ввести число от 1 до 4 (четверть)"
    }
    
    
    if(quarter < 0 && quarter < 5)
    {
        
    }
    else
        return "Нужно ввести число от 1 до 4(четверть)";
}