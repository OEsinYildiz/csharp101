void X(int[] arr)
{
    int[] sortedArr = arr;
    // Array.Sort(sortedArr);
    int swaps = 0;
    for (int i = 0; i < arr.Length-1; i++)
    {
        // if(sortedArr==arr)
        //     break;
        if (arr[i]>arr[i+1])
        {
            (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
            swaps++;
        }
    }

    Console.WriteLine(swaps);
    Console.WriteLine(arr.First());
    Console.WriteLine(arr.Last());
    
}

X(new []{3,2,1});