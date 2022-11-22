Console.Write("Введите кординаты X: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординаты Y: ");
int numY = Convert.ToInt32(Console.ReadLine());

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;    
}

int quar = Quarter(numX, numY);
string result = quar > 0 ? 
            $"Указаные кординаты соответствуют четверти--> {quar}":
            "Введены не коректные кординаты";

Console.WriteLine(result);
