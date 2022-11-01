// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("enter num");
int num  = int.Parse(Console.ReadLine());
for (int i = 0; i <= num; i++)
{
    int num2 = 0;
    num2 += i;
    System.Console.WriteLine(num2);
}
