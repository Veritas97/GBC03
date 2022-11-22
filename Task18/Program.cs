Console.Write("Введите кординаты: ");
int numquar = Convert.ToInt32(Console.ReadLine());

string Range(int quar)
{
    if (quar==1) return "(x > 0 и y > 0)";
    if (quar==2) return "(x < 0 и y > 0)";
    if (quar==3) return "(x < 0 и y < 0)";
    if (quar==4) return "(x > 0 и y < 0)";
    return "Введен неректный диапозон";
}
string range = Range(numquar);

Console.Write($"Кординаты в указоной четверти -- {range}");