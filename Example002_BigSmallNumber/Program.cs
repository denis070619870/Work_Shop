// Найти из 2-х чисел какое наибольшее, а какое наименьшее

int a = new Random().Next(1, 10);
Console.WriteLine(a);
int b = new Random().Next(1, 10);
Console.WriteLine(b);

if ( a > b)
{
    Console.WriteLine(a + " " + "Наибольшее число");
    Console.WriteLine(b + " " + "Наименьшее число");
}
else
{
    Console.WriteLine(b + " " + "Наибольшее число");
    Console.WriteLine(a + " " + "Наименьшее число");
}