Console.WriteLine("Введите число N для построения таблицы кубов от 1 до N");

int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"Число {i} возведённое в куб = {Math.Pow(i, 3)}");
}   