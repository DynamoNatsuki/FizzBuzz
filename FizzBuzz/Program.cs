/*Exercise description:
Write a console program in C# that prints all numbers from 1 to 100 on each line.

If the number is divisible by 3, print "Fizz" instead of the number. For example, 3 and 6 should be replaced with Fizz. (divisible operator %) % => a-(a/b)*b = 0 

If the number is divisible by 5, print "Buzz" instead of the number. For example, 5 and 10 should be replaced with Buzz.

If the number is divisible by both 3 and 5, print FizzBuzz instead. For example, 15 and 30 should be replaced with FizzBuzz.*/

for(int i = 1; i <= 100; i++) //The variable i is initially equal to 1. i can be a number up to and including 100. Each time the code repeats itself, i is increased by 1.
{
    if(i % 3 == 0 && i % 5 == 0)  //If the number is divisible by both 3 and 5, print FizzBuz.
    {
        Console.WriteLine("FizzBuzz");
    }
    
    else if(i % 3 == 0) //If the number is divisible by 3, print "Fizz".
    {
        Console.WriteLine("Fizz");
    }

    else if (i % 5 == 0) //If the number is divisible by 5, print "Buzz".
    {
        Console.WriteLine("Buzz");
    }

    else //Print all numbers that are not divisible by 3 and/or 5.
    {
        Console.WriteLine(i); 
    }
}