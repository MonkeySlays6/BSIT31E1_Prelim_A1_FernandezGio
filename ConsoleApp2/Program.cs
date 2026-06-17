// FizzBuzz - Starter
// TODO: Write a program that prints numbers 1 to 100.
// For multiples of 3, print "Fizz" instead of the number.
// For multiples of 5, print "Buzz".
// For multiples of both 3 and 5, print "FizzBuzz".

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}