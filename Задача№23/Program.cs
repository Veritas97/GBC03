Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

void square (int n)
{
    for (int i = 1; i <= n; i++)
    {
       Console.WriteLine($"{i} | {i*i*i}");
    }
}
square(numN);