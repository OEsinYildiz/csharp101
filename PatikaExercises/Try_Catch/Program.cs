using System.Net;

try
{
    Console.WriteLine("Sayı Gir");
    int sayi = Convert.ToInt32(Decimal.MaxValue);
    Console.WriteLine(sayi);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex);
    Console.WriteLine("Argument");

}
catch (FormatException ex)
{
    Console.WriteLine(ex);
    Console.WriteLine("Format");
}
catch (OverflowException ex)
{
    Console.WriteLine(ex);
    Console.WriteLine("Overflow");
}
finally
{
    Console.WriteLine("İşlem Tamam!");
}