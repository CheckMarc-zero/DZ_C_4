int A = insertNumber("Введите возводимое в степень число:");
int B = insertNumber("Введите натуральную степень, в которую будет возводиться число:");

if(B<1) Console.WriteLine("Степень должна быть натуральным числом.");
else 
 {
 int stepen = funcStepen(A,B);
Console.Write("Результат:");
Console.WriteLine(stepen);
}

//Метод ввода данных
int insertNumber (string message)
{
    Console.WriteLine(message);
int number = int.Parse(Console.ReadLine());
return number;
}

//Метод вычисления степени
int funcStepen (int a, int b)
{
    int need = a;
    for (int i=2; i<=b; i++) need = A*need;
    return need;
}
