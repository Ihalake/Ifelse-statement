Console.WriteLine("Enter your marks");
int maths = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your marks");
int biology = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your marks");
int physics = Convert.ToInt32(Console.ReadLine());

int result = (maths + biology + physics) / 3;

if (result < 35)
{
    Console.Write("Fail");
}
else if (result >= 35 && result <= 50)
{
    Console.Write("Pass class");
}
else if (result > 50 && result <= 60)
{
    Console.Write("Second class");
}
else if (result > 60 && result <= 70)
{
    Console.Write("First class");
}
else     
{
    Console.Write("Distinction class");
}
