string message = "Dersimiz String Metotlar";
string note = "Öğrenilmesi gereken String Metotlar";
string[] arr = message.Split(' ');


// Concat birleştirme için kullanılır
Console.WriteLine(String.Concat(message, note));

// Birinci element ile IEnumrable değişkeni string olarak yazar
Console.WriteLine(string.Join('-', arr));


// Karakter sayısı olarak karşılaştırır. Birincisi büyükse 1; eşitse 0 küçükse -1
Console.WriteLine(message.CompareTo(note));
Console.WriteLine(note.CompareTo(note));
Console.WriteLine(note.CompareTo(message));


// false ile büyük küçük harf duyarlıdır
Console.WriteLine("______");
Console.WriteLine(String.Compare(message, note, false));


Console.WriteLine("______");
Console.WriteLine(note.EndsWith("lar"));
Console.WriteLine(note.EndsWith("la"));

Console.WriteLine("______");
Console.WriteLine(note.IndexOf("m"));
Console.WriteLine(note.IndexOf("gereken"));

Console.WriteLine("_________");
Console.WriteLine(message.Insert(0, "Selamlar "));


// Karakter sayısı verilen sayıya eşit olacak kadar ekleme yapar.
Console.WriteLine("____________________________");
Console.WriteLine(note.Length);
string test = note.PadRight(36, '-');
Console.WriteLine(test);
Console.WriteLine(test.Length);


// 5. indexden başlayarak sonuna kadar siler 5 dahil kanka
Console.WriteLine("____________");
Console.WriteLine(note.Remove(5));
Console.WriteLine(note.Remove(5 , 3));

//4. indexten öncekini siler. Veya 4. indexten sonra 6 karakter uzunluğunu alır 
Console.WriteLine("__________________");
Console.WriteLine(note.Substring(4));
Console.WriteLine(note.Substring(4, 6));
