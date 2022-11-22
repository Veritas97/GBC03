Console.Write("Введите пятизначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = num1;
int num3 = 0;

while (num1 > 0)
{
    int num4 = num1 % 10;
    num3 = num3 * 10 + num4;
    num1 = num1 / 10;
}
if (num2 == num3) Console.WriteLine("Это палиндром!");
else Console.WriteLine("Это не палиндром!");