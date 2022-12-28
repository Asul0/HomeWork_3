using static System.Console;
Clear();

WriteLine("Введите трёхзначное  число ");
int number = Convert.ToInt32(ReadLine());

int secomd = number/10000;

int a = number/1000;
int second2 = a%10;

int b= number/10;
int second3 = b%10;


int second4 = number%10; 


if (secomd==second4 && second2==second3)
{
    WriteLine("полиндром");
}
else
{
    WriteLine("не полиндром");
}
