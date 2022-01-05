int FindSmallestIndex(List<int> list)
{
    int smallest = list[0];
    int smallestIndex = 0;

    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] < smallest)
        {
            smallest = list[i];
            smallestIndex = i;
        }
    }

    return smallestIndex;
}

void SelectionSort(List<int> list)
{
    int listLenght = list.Count;
    List<int> newArr = new List<int>();
    for (int i = 0; i < listLenght; i++)
    {
        int smallestIndex = FindSmallestIndex(list);
        newArr.Add(list[smallestIndex]);
        list.Remove(list[smallestIndex]);
    }

    foreach (var item in newArr)
    {
        Console.WriteLine(item);
    }
}

SelectionSort(new List<int>(){5,3,6,2,10});