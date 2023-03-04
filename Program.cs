// усложнённая задача от преподавателя
// ввести неопределённое количество чисел с признаком остановки ввода словом "stop"
// подсчитать количество чисел больше нуля
bool DigitNumber (string message)
{
    foreach (char a in message)
    {
        if (a < '-' || a > '-')
        {
             if (a < '0' || a > '9')
            {
                return false;
            }
        }
    }
    return true;
}

int numberB = 0;
bool i = true;
for (int count = 0; i == true; count++)
{
    string st = Console.ReadLine();
    i = DigitNumber (st);
    if (i == true)
    {
        int numberA = Convert.ToInt32(st);
           if (numberA > 0)
        {
            numberB++;
        }
    }
}
Console.WriteLine ("Количество чисел больше нуля = " + numberB);
