int month = DateTime.Now.Month;
switch (month)
{
    case 1:
        Console.WriteLine("Ocak");
        break;
    case 2:
        Console.WriteLine("Şubat");
        break;
    default:
        Console.WriteLine("Aylarrrr");
        break;
}

int monthNow = DateTime.Now.Month-1;
switch (monthNow)
{
    case 1:
    case 11:
        Console.WriteLine("Ocak");
        break;
    case 2:
    case 12:
        Console.WriteLine("Şubat");
        break;
}