// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine ("Введите число N");
int N = int.Parse (Console.ReadLine ());
int comp = 1;
int a = 1;

while (a <= N)
{
    comp = comp * a;
    a++;
}

Console.WriteLine ("Произведение чисел от 1 до N = " +comp);
