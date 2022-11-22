Console.Write("Введите кординаты точек A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординаты точек A1: ");
int numA1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординаты точек A2: ");
int numA2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординаты точек B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординаты точек B1: ");
int numB1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординаты точек B2: ");
int numB2 = Convert.ToInt32(Console.ReadLine());

double Sum(int a, int a1, int a2, int b, int b1, int b2)
{
    double res = (a - b) * (a - b);
    double res1 = (a1 - b1) * (a1 - b1);
    double res2 = (a2 - b2) * (a2 - b2);
    double result = Math.Sqrt(res + res1 + res2);
    return result;
}

double ress = Sum(numA, numA1, numA2, numB, numB1, numB2);

double resRound = Math.Round(ress, 2, MidpointRounding.ToZero);
Console.Write(resRound);