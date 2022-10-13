int A = insertNumber("Введите число:");

A = Math.Abs(A);

int result = sumCifr(A);
Console.Write("Сумма цифр числа:");
Console.WriteLine(result);

//Метод ввода данных
int insertNumber (string message)
{
Console.WriteLine(message);
int number = int.Parse(Console.ReadLine());
return number;
}

//Метод суммы цифр числа
int sumCifr (int N)
{
int sum = 0;
while (N != 0)
{
    sum = sum + N%10;
    N = N/10;
}
return sum;
}