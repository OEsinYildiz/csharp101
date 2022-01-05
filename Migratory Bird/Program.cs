//TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

int result = Result.migratoryBirds(arr);

// textWriter.WriteLine(result);
//
// textWriter.Flush();
// textWriter.Close();

class Result
{
    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        arr.Sort();
        var newArr = arr.Distinct().ToList();
        
        Dictionary<int, int> list = new Dictionary<int, int>();
        for (int i = 0; i < newArr.Count(); i++)
        {
           int repeat = arr.Where(x => x.Equals(newArr[i])).Count();
            list[newArr[i]] = repeat;
            repeat = 0;
        }
        
        int result = list.Values.Max();
        return list.First(x => x.Value == result).Key;
     
    }
}