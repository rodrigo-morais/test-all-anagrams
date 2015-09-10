using System;
using System.Collections.Generic;

public class AllAnagrams
{
    public static ICollection<string> GetAllAnagrams(string str)
    {
        var length = str.Length - 1;
        var anagrams = new List<string>();
        var newStr = str;

        anagrams.Add(str);

        do
        {
            for (var intCount = length; intCount > 0; intCount = intCount - 1)
            {
                var letter = newStr[intCount];
                newStr = newStr.Remove(intCount, 1);
                newStr = newStr.Substring(0, intCount - 1) + letter + newStr.Substring(intCount - 1, length - (intCount - 1));
                if (anagrams.Contains(newStr) == false)
                {
                    anagrams.Add(newStr);
                }
            }
        } while (str != newStr);

        return anagrams;
    }

    public static void Main(string[] args)
    {
        ICollection<string> anagrams = GetAllAnagrams("abba");
        foreach (string a in anagrams)
            Console.WriteLine(a);
    }
}