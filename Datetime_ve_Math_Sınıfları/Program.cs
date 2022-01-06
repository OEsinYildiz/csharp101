// See https://aka.ms/new-console-template for more information

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine("__________");
Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine("__________");
Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());


Console.WriteLine("__________");
Console.WriteLine(DateTime.Now.ToShortTimeString());
Console.WriteLine(DateTime.Now.ToLongTimeString());

// Datetime Format
Console.WriteLine("Datetime Format");
Console.WriteLine("______________");
Console.WriteLine(DateTime.Now.ToString("dd")); //int olarak gün
Console.WriteLine(DateTime.Now.ToString("ddd")); //Günün string olarka üç harflisi
Console.WriteLine(DateTime.Now.ToString("dddd")); //Günün string olarka tam hali

Console.WriteLine("__________");
Console.WriteLine(DateTime.Now.ToString("MM")); //04
Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
Console.WriteLine(DateTime.Now.ToString("MMMM")); //April


Console.WriteLine("__________");
Console.WriteLine(DateTime.Now.ToString("yy")); //22
Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022


#region Math Kütüphanesi

Console.WriteLine("-------------");
Console.WriteLine("Math Kütüphanesi");
Math.Abs(-25); // 25 döner


Console.WriteLine(Math.Ceiling(22.3)); // Her zaman yukarı yuvarlar
Console.WriteLine(Math.Round(22.3)); // Nereye yakınsa oraya yuvarlar
Console.WriteLine(Math.Round(22.7)); // Nereye yakınsa oraya yuvarlar
Console.WriteLine(Math.Floor(22.7)); // Aaşağı yuvarlar


Console.WriteLine(Math.Max(10, 12));
Console.WriteLine(Math.Min(10, 12));

Console.WriteLine(Math.Pow(3,4));
Console.WriteLine(Math.Sqrt(81));
Console.WriteLine(Math.Log(64)); // log e tabanında karşılığı
Console.WriteLine(Math.Log(Math.E)); // 
Console.WriteLine(Math.Exp(3)); // e üzeri 3
Console.WriteLine(Math.Log10(100));
Console.WriteLine(Math.PI);
Console.WriteLine(Math.E);

#endregion

