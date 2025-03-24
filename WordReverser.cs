using System;

class WordReverser {
    static void Main() {
        Console.Write("🔤 Enter a word: ");
        string word = Console.ReadLine();
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine("🔄 Reversed: " + new string(charArray));
    }
}
