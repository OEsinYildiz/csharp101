using System;
using System.Text;

namespace degiskenler
{
    class Example
    {
        public char Name;

        public override string ToString()
        {
            try
            {
                return Name.ToString().ToUpper();
            }
            catch (Exception e)
            {
                throw new Exception("Yapılamadı", e);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Example exp = new();
            exp.Name = 'p';
            Console.WriteLine(exp.Name.ToString());

            string hours = DateTime.Now.ToString("HH:mm");
            System.Console.WriteLine(hours);

            // StringBuilder stringBuilder = new(inputString);
            // stringBuilder.Append(" ");
            // stringBuilder.Append("Esin");
            // Console.WriteLine(stringBuilder.ToString(true));
            // string[] authors = { "Mahesh Chand ", "Chris Love ", "Dave McCarter ", "Praveen Kumar"};
            // string arrStr = string.Concat(authors);
            // System.Console.WriteLine(arrStr);
            // string strArrStr = string.Concat("Authors: ", authors);
            // Console.WriteLine(strArrStr);

            // DateTime time = new();
            // time = DateTime.Today;
            // System.Console.WriteLine(time);
            // Console.WriteLine(inputString);
            // Console.WriteLine("Hello World!");
        }
    }
}