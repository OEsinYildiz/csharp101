int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

Result.plusMinus(arr);

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double positiveCount = arr.Count(x => x > 0);
        double negativeCount = arr.Count(x => x < 0);
        double zeroCount = arr.Count(x => x == 0);
        double sum = arr.Count;
        Console.WriteLine(positiveCount/sum);
        Console.WriteLine(negativeCount/sum);
        Console.WriteLine(zeroCount/sum);
    }

}