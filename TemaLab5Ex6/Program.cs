/*Screiti un program care va numara vocalele dintr-un sir de caractere citit de
la tastatura.*/


Console.WriteLine("Enter a string:");
string inputString = Console.ReadLine();

int vowelCount = CountVowels(inputString);

Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
    

    static int CountVowels(string inputString)
{
    int count = 0;
    foreach (char c in inputString.ToLower())
    {
        if (IsVowel(c))
        {
            count++;
        }
    }
    return count;
}

static bool IsVowel(char c)
{
 
    return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
}