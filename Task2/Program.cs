Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

//Вызываем метод расчета сыммы чисел, в аргумент которого передаем число и метод расчета количество цифр в числе
SumOfDigits(num, GetCalcSize(num));

//Метод расчета длины числа
int GetCalcSize(int num)
{
   int count = 0;
    while(num > 0)
    {
        num /= 10;
        count++;
    } 
    return count;
}

//Метод расчета суммы чисел
void SumOfDigits(int num, int count)
{    
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        sum += num%10;        
        num /= 10;
    }
    Console.WriteLine(sum);
}