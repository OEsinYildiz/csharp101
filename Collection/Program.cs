// See https://aka.ms/new-console-template for more information

List<int> list = new()
{
    11, 22, 44, 55, 78, 99, 201, 235, 5874
};



//Index ile Element Cıkarma
list.RemoveAt(1);

//Dogrudan eleman çıkarma
list.Remove(22);

// Contains Kullanımı
var result =list.Contains(44);

//Eleman İle Index'e Erişme
var index =list.BinarySearch(22);
Console.WriteLine(index);

//Diziyi listeye çevirme
string[] arr = {"Kaplan", "Aslan", "Kuala"};
List<string> animals = new List<string>(arr);

//Liste içerisinde class Tutmak
List<Person> persons = new List<Person>()
{
    new Person(){Name = "Ömer", LastName = "Yıldız"}
};


class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
}