int Sum(int[] arr)
{
    int size = arr.Length;
    if (size == 1)
        return arr[0];
    int[] arrResize = arr;
    Array.Resize(ref arrResize, size - 1);
    return arr[size - 1] + Sum(arrResize);

}

Console.WriteLine(Sum(new []{1,2,3,4,5}));