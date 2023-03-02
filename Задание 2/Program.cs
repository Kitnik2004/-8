static int Payment(int rem)
{
    Console.WriteLine("Сумма долга равна {0}", rem);
    Console.WriteLine("Сколько вы хотите внести денег?");
    int take = int.Parse(Console.ReadLine());
    if (rem > 0)
    {
        rem = rem - take;
        if (rem>0)
        {
            Console.WriteLine("Осталось внести {0}", rem);
        }

    }


    return rem;
}


    int rem = 700;
    while (rem > 0)
        {
            rem = Payment(rem);
        }
Console.WriteLine("Вы погасили кредит! Переплата составила {0}",rem*-1);