int N = Convert.ToInt32(Console.ReadLine().Trim());

if (N % 2 == 1)
{
    Console.WriteLine("Weird");
}
else
{
    if (2 <= N && N <= 5)
    {
        Console.WriteLine("Not Weird");
    }

    if (6 <= N && N <= 20)
    {
        Console.WriteLine("Weird");
    }

    if (N > 20)
    {
        Console.WriteLine("Not Weird");
    }
}