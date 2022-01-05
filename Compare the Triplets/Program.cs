static List<int> compareTriplets(List<int> a, List<int> b)
{
    int x=0, y = 0;
    for (int i = 0; i < a.Count; i++)
    {
        
        if (a[i]>b[i])
        {
            x++;
        }

        if (a[i] < b[i])
        {
            y++;
        }
    }

    List<int> result = new List<int>();
    result.Add(x);
    result.Add(y);
    return result;
}

compareTriplets(new List<Int32>(){1,2,3}, new List<Int32>(){1,32,3});