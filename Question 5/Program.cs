// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("enter your two number");
System.Console.WriteLine("enter first number ");
int firstnum = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter secondnumber and end with 5");
int secondnumber = int.Parse(Console.ReadLine());
if (firstnum % 5 == 0)
{
    int num = firstnum+5,lop = num + 5;
    System.Console.WriteLine($"the range between  {firstnum} and {secondnumber} is {num},{lop} ");

}
