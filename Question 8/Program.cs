// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("enter firstnum");
int firstnum = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter seconnum");
int secondnum = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter thirdnum");
int thirdnum = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter fourthnum");
int fourthnum = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter fifthnum");
int fifthnum = int.Parse(Console.ReadLine());
int greatest = 0;
if (firstnum > greatest)
{
     greatest = firstnum ;
}
 if (secondnum > greatest)
{
      greatest = secondnum;
}
 if (thirdnum > greatest)
{
    greatest = thirdnum;
}
 if (fourthnum > greatest)
{
    greatest = fourthnum;
}
 if (fifthnum > greatest)
{
    greatest = fifthnum;
}
System.Console.WriteLine($"the greatest of the five number is {greatest}");
