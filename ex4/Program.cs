//Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine ("Введите число N");
int N = int.Parse (Console.ReadLine ());
int b = 0;
int c = 1;
while (b <= N)
{
    c = b * b * b;
    if (c % 2 == 0)
    {
        Console.WriteLine ($"Куб числа {b} равен {c}");
    }
    b++;
}
