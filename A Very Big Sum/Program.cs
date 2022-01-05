static long aVeryBigSum(List<long> ar)
{
    return ar.Sum(x => x);
}

Console.WriteLine(aVeryBigSum(new List<long>{1,2,3,4,5}));