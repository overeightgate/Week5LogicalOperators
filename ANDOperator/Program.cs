﻿
int math, biology, chemistry;

Console.WriteLine("Enter your Math results:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology results");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry results");
chemistry = Int32.Parse(Console.ReadLine());


if (math >= 90 && math >= 90 && chemistry >=90)
{
    Console.WriteLine("Congratulations! You got accepted");
}

else
{
    Console.WriteLine("Your application hasn't been apporved");
}