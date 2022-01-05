// See https://aka.ms/new-console-template for more information

string result = "Sonuç";

string response = result;

result = "Sonuc-2";

int a = 5;
ref int b = ref a;

a = 6;

//Console.WriteLine(a);
//Console.WriteLine(b);
MyClass nesne = new MyClass
{
    Name = "Ömer",
    Id = 1
};

//Shallow Copy
// Veri bir iken iki olmuyorsa
var test = nesne;

nesne.Id = 2;
nesne.Name= "Ömer";

Console.WriteLine(nesne.Name+ " " + nesne.Id);
Console.WriteLine(test.Name+ " " + test.Id);

class MyClass
{
    public string Name { get; set; }
    public int Id { get; set; }
}


//Console.WriteLine(result);
//Console.WriteLine(response);