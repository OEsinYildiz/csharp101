static int birthdayCakeCandles(List<int> candles)
{
    #region NotWorking

    /*Dictionary<int, int> same = new Dictionary<int, int>();
    int[] arr = candles.ToArray();
    Array.Sort(arr);
    int result = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (same.ContainsValue(arr[i]))
        {
            //result=candles.Count(x => x.Equals(candles[i]));
            int index = Array.IndexOf(arr,arr[i]);
            while (arr[i] == arr[index] && index < arr.Length - 1)
            {
                result++;
                index++;
            }
            break;
        }
        else
            same[i] = arr[i];
    }
    return result;*/

    #endregion
    
    candles.Sort();
    int lenght = candles.Count;
    int result = 0;
    for (int i = 0; i < lenght-1; i++)
    {
        if (candles[i] == candles[lenght - 1])
            result++;
    }

    return result;

}

List<int> RandomList()
{
    List<int> list = new List<int>();
    var random = new Random();
    for (int i = 1; i < 100001; i++)
    {
        list.Add(random.Next(1,1000001));
    }

    return list;
}

Console.WriteLine(birthdayCakeCandles(RandomList()));