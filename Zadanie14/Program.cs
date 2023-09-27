using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Введите номер месяца (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Введите число (1-31): ");
        int day = int.Parse(Console.ReadLine());

        
        DateTime date = new DateTime(2024, month, day);

       
        int Week = (int)date.DayOfWeek;

       
        switch(Week) 
        {
            case 0:
                Console.WriteLine("воскресенье");
                break;
            case 1:
                Console.WriteLine("понедельник");
                break;
            case 2:
                Console.WriteLine("вторник");
                break;
            case 3:
                Console.WriteLine("среда");
                break;
            case 4:
                Console.WriteLine("четверг");
                break;
            case 5:
                Console.WriteLine("пятница");
                break;
            case 6:
                Console.WriteLine("суббота");
                break;
            default:
                Console.WriteLine("недопустимый день недели");
                break;
        }
        Console.WriteLine("Если хотите повторить ввод, введите 1, иначе любую другую цифру.");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a == 1)
        {
            Main();
        }


    }
}