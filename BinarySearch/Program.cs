void Binary_Search(List<int> list, int item)
{
    int high = list.Count - 1;
    int low = 0;
    list.Sort();
    Console.WriteLine(list.IndexOf(3));

    while (low < high)
    {
        int mid = (low + high) / 2;
        var guess = list[mid];
        if (guess == item)
        {
            Console.WriteLine(mid);
        }

        if (guess > item)
            high = mid - 1;
        else
            low = mid + 1;
    }
}


Binary_Search(new List<int>() { 3, 7, 5, 4, 6, 2, 1, 9 }, 6);