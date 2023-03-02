static int Ras(int x=1)
{
    int res = 1;
    do
    {
        res *= x;
        x -= 1;
    } 
    while (x > 0);
    return res;
}
//Честно говоря, не понимаю как именно сюда воткнуть рекурсию

Console.WriteLine("Введите кол-во клиентов");
int x = int.Parse(Console.ReadLine());
int res = Ras(x);
Console.WriteLine(res);
