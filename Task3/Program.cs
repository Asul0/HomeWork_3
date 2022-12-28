using static System.Console;
Clear();

WriteLine("Введите число N: ");
int a = Convert.ToInt32(ReadLine());
int i = 1;

while(i <= a)
{
    Write($"{i*i*i} ");
    i++;
}
