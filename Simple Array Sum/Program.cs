static int simpleArraySum(List<int> ar)
{
    return ar.Sum(x => x);
}

Console.WriteLine(simpleArraySum(new List<int>{1,2,4}));