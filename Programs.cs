public class Stringprograms

{
    private static string s3;

    public static void Main(string[] args)
    {
        Console.Clear();
        //largest_shortest_word("my name is kalp  i love coding");
        //duplicate_string("Good Grammer");
        //duplicate_word("hey kalp is kalp so, kalp is good good boy");
        //frequency("Kalpa");
        //sbpalindrome("My Name is Kalp, Founder & CEO of Kalpu_official");
        //sep_string("KALPISGOODBOY");
        //swap_var ("GOOD" , "Kalp");

        Console.ReadLine();
    }
    //Program to Find the Largest and Smallest Word in a String
    private static void largest_shortest_word(string str)
    {
        string s1 = str;
        String word = "", small = "", large = "";
        String[] words = new String[100];
        int length = 0;

        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != ' ')
            {
                word = word + s1[i];
            }
            else
            {
                words[length] = word;
                length++;
                word = "";
            }
        }
        small = large = words[0];
        for (int k = 0; k < length; k++)
        {
            if (small.Length > words[k].Length)
                small = words[k];
            if (large.Length < words[k].Length)
                large = words[k];
        }
        Console.WriteLine("Smallest word: " + small);
        Console.WriteLine("Largest word: " + large);
    }
    //Program to Find the Duplicate Characters in a String
    private static void duplicate_string(string str)
    {
        int count;
        char[] s1 = str.ToCharArray();
        Console.WriteLine("Duplicate characters in a given string: ");
        for (int i = 0; i < s1.Length; i++)
        {
            count = 1;
            for (int j = i + 1; j < s1.Length; j++)
            {
                if (s1[i] == s1[j] && s1[i] != ' ')
                {
                    count++;
                    s1[j] = '0';
                }
            }
            if (count > 1 && s1[i] != '0')
                Console.WriteLine(s1[i]);
        }
    }
    //Program to Find Reverse of a String...
    private static void duplicate_word(string str)
    {
        int count;
        String s1 = str;
        s1 = s1.ToLower();
        String[] words = s1.Split(' ');

        Console.WriteLine("Duplicate words in a given string : ");
        for (int i = 0; i < words.Length; i++)
        {
            count = 1;
            for (int j = i + 1; j < words.Length; j++)
            {
                if (words[i].Equals(words[j]))
                {
                    count++;
                    words[j] = "0";
                }
            }
            if (count > 1 && words[i] != "0")
                Console.WriteLine(words[i]);
        }
    }
    //Program to Find the Frequency of Characters
    private static void frequency(string str1)
    {
        String str = str1;
        int[] freq = new int[str.Length];
        int i, j;
        char[] string1 = str.ToCharArray();

        for (i = 0; i < str.Length; i++)
        {
            freq[i] = 1;
            for (j = i + 1; j < str.Length; j++)
            {
                if (string1[i] == string1[j])
                {
                    freq[i]++;
                    string1[j] = '0';
                }
            }
        }
        Console.WriteLine("Characters and their corresponding frequencies");
        for (i = 0; i < freq.Length; i++)
        {
            if (string1[i] != ' ' && string1[i] != '0')
                Console.WriteLine(string1[i] + "-" + freq[i]);
        }
    }
    // Program to separate the individual characters from a string
    private static void sep_string(string str1)
    {
        String string1 = str1;
        for (int i = 0; i < string1.Length; i++)
        {
            Console.Write(string1[i] + " ");
        }
    }
    //Program to swap two string variables without using third or temp variable
    private static void swap_var(string p, string q)
    {
            String a = p;
            String b = q;
            
            a = a + b;
            a = a.Substring(0, (a.Length - b.Length));
            a = a.Substring(b.Length);
            Console.WriteLine("Strings after swapping:"+ a + " " + b);
    }

}
