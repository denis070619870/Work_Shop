// Показать четные числа от 1 до N

Console.WriteLine("Введите число до которого будт показаны все четные числа: ");
int userNumber = int.Parse(Console.ReadLine());
int count = 1;

Console.WriteLine(" ");
while(count < userNumber)
{
    if(count % 2 ==0)
    {
        Console.WriteLine(count + " ");
    }
    count ++;
}
Console.WriteLine(" ");