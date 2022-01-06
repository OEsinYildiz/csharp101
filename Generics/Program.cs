// Write your code here




static void PrintArray<T>(T[] element)
{
    foreach (var item in element)
    {
        Console.WriteLine(item);
    }    
}

int n = Convert.ToInt32(Console.ReadLine());
int[] intArray = new int[n];
for (int i = 0; i < n; i++)
{
    intArray[i] = Convert.ToInt32(Console.ReadLine());
}
		
n = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[n];
for (int i = 0; i < n; i++)
{
    stringArray[i] = Console.ReadLine();
}
		
PrintArray<Int32>(intArray);
PrintArray<String>(stringArray);