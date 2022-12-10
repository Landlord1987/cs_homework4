Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень возведения числа: ");
int degree = Convert.ToInt32(Console.ReadLine());

Exponentiation(num, degree);

void Exponentiation(int num, int degree)
{    
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result *= num;
    }
    Console.WriteLine(result);
}