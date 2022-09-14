namespace StringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            String str = "The quick brown fox jumps over the lazy dog";

            Console.WriteLine("a) Print the character at the 12th index.");
            Console.WriteLine(str[12]);

            Console.WriteLine("\nb) Check whether the String contains the word “is”.");
            if (str.Contains("is") == true)
                Console.WriteLine("Word Found");
            else
                Console.WriteLine("Word Not Found");

            Console.WriteLine("\nc) Add the string “and killed it” to the existing string.");
            str =  String.Concat(str," and killed it");
            Console.WriteLine(str);
            str = "The quick brown fox jumps over the lazy dog";

            Console.WriteLine("\nd) Check whether the String ends with the word “dogs”.");
            if (str.EndsWith("Dog") == true)
                Console.WriteLine("End with dog");
            else
                Console.WriteLine("Not end with dog");

            Console.WriteLine("\ne) Check whether the String is equal to “The quick brown Fox jumps over the lazy Dog”.");
            if (str.Equals("The quick brown Fox jumps over the lazy Dog") == true)
                Console.WriteLine("Both the strings are equal");
            else
                Console.WriteLine("Strings are not equal");

            Console.WriteLine("\nf) Check whether the String is equal to “THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG”.");
            if (str.Equals("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG") == true)
                Console.WriteLine("Both the strings are equal");
            else
                Console.WriteLine("Strings are not equal");

            Console.WriteLine("\ng) Find the length of the string: ");
            Console.WriteLine("lentgh of the string is: " + str.Length);

            Console.WriteLine("\nh) Check whether the String is matches to “The quick brown Fox jumps over the lazy Dog”.");
            if (str.Equals("The quick brown Fox jumps over the lazy Dog") == true)
                Console.WriteLine("Both the strings are equal");
            else
                Console.WriteLine("Strings are not equal");

            Console.WriteLine("\ni)Replace the word “The” with the word “A”.");
            str = str.Replace("The", "A");
            Console.WriteLine(str);

            Console.WriteLine("\nl) Print the above string in completely lower case.");
            str = str.ToLower();
            Console.WriteLine(str);

            Console.WriteLine("\nm) Print the above string in completely upper case.");
            str = str.ToUpper();
            Console.WriteLine(str);

            Console.WriteLine("\nn) Find the index position of the character “a”.");
            Console.WriteLine(str.IndexOf('a'));

            Console.WriteLine("\no) Find the index position of the character “e”.");

            int index = 0;
            char c = 'e';
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'E')
                     index = i;
            }
                Console.WriteLine("Last index is " + index);

            Console.WriteLine("\np) Prompt the user to enter the home directory of Tomcat server. To the path that user enters, add another path to  WebApps/MyApps/Images  directory and display it in the console. Use verbatim string literals. ");
            Console.WriteLine("enter the home directory of Tomcat server: ");
            String str2 = Console.ReadLine();

            str2 = String.Concat(str2, "/WebApps/MyApps/Images");
            Console.WriteLine(str2);

            Console.WriteLine("\nq)Write a C# code that has a constant string that represents poem lines ");
            const String str3 = "I WANDER'D lonely as a cloud\r\nThat floats on high o'er vales and hills, \r\nWhen all at once I saw a crowd,\r\nA host, of golden daffodils;Beside the lake, beneath the trees,\r\nFluttering and dancing in the breeze.\r\n";
            Console.WriteLine(str3);    
        }
    }
}