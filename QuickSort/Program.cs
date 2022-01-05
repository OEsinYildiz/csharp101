List<int> QuickSort(List<int> list)
{
    if (list.Count <= 1)
        return list;
    int pivot = list.Count / 2;
    int pivotValue = list[pivot];
    list.Remove(pivotValue);
    List<int> newList = new List<int>();
    List<int> bigList = new List<int>();
    List<int> littleList = new List<int>();
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] > pivotValue)
        {
            bigList.Add(list[i]);
        }
        else
        {
            littleList.Add(list[i]);
        }
    }
    
    newList.AddRange(QuickSort(littleList));
    newList.Add(pivotValue);
    newList.AddRange(QuickSort(bigList));
    return newList;
}

foreach (var item in QuickSort(new List<int>(){33,10,15,7,23,12,63,75,89,100,230,3256,89552}))
{
    Console.WriteLine(item);
}
