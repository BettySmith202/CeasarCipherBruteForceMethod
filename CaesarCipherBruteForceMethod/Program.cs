class CaesarCipher
{
    static void Main(string[] args)
    {
        char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        Console.Write("Enter Ciphertext: ");
        string ciphertext = Console.ReadLine();
        Console.WriteLine("\n");

        BruteForceMethod(alphabet, ciphertext);
    }

    public static void BruteForceMethod(char[] arr, string ciphertext)
    {
        for(int i = 1; i < 26; i++)
        {
            Console.Write(i + ".   ");
            string plaintext;
            foreach(char c in ciphertext)
            {
                int index = Array.IndexOf(arr,c);
                int newindex = index - i;
                if(newindex < 0)
                {
                    newindex = newindex + 26;
                }
                Console.Write(arr[newindex]);
            }
            Console.WriteLine();
        }
        Console.Write("Enter number that is plaintext: ");
        string alphaindex = Console.ReadLine();
        int targetindex = 26 - int.Parse(alphaindex);

        Console.Write("Key = " + targetindex+" | ");
        foreach(char c in ciphertext)
        {
            int index = Array.IndexOf(arr, c);
            int newindex = index + targetindex;
            if (newindex > 25)
            {
                newindex = newindex - 26;
            }
            Console.Write(arr[newindex]);
        }

    }
}