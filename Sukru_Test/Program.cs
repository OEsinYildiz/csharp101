void MovieSelect(List<int> list)
{
    
    // int pivot = list.Count / 2;
    // int pivotValue = list[pivot];

    /*#region negatif

    Dictionary<int, int> arr = new Dictionary<int, int>();
    int sum = 0;
    for (int i = 1; i < list.Count+1; i++)
    {
        sum += list[i-1];
        arr[i] = sum;
    }

    List<int> value = new List<int>(arr.Values);
    var pivot = arr.Max(x => x).Value;
    
    int pivotStart = 0;
    for (int i = pivot; i > 1; i--)
    {
        if (list[i] < 0)
            pivotStart = i - 1;
    }

    int result = 0;
    for (int i = pivotStart; i < pivot; i++)
    {
        result += list[i];
    }

    return result;

    #endregion*/
   
    //Dictionary<int, int> dictionary = new Dictionary<int, int>();
    List<int> listResult = new List<int>();
    for (int i = 0; i < list.Count; i++)
    {
        int sum = 0;
        for (int j = i; j < list.Count; j++)
        {
            sum += list[j];
            listResult.Add(sum);
        }
    }

    int resultPoint = listResult.Max();
}


MovieSelect(new List<int>(){-6, 3, 9, 1, 2, 8, -7, 8});
