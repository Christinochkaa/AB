using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\file\\filePath.txt";
        string content = File.ReadAllText(filePath);

        int maxCount = 0;
        int currentCount = 0;

        for (int i = 0; i < content.Length - 1; i++)
        {
            string pair = content.Substring(i, 2);
            if (pair == "AB" || pair == "CB")
            {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            }
            else
            {
                currentCount = 0;
            }
        }

        Console.WriteLine($"Максимальное количество идущих подряд пар AB или CB: {maxCount}");
    }
}