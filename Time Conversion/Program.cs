// See https://aka.ms/new-console-template for more information


string s = Console.ReadLine();

string result = Result.timeConversion(s);
Console.WriteLine(result);

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        return string.Format("{0:HH:mm:ss}", DateTime.Parse(s));
    }

}