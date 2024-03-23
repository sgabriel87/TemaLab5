/*Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit
de la tastatura, ignorand caseing-ul literelor.
Exemplu:
Input: Elena are mere
Output: e apare de 5 ori*/


Console.WriteLine("Enter the string:");
string inputString = Console.ReadLine();

char mostFrequentChar = FindMostFrequentCharacter(inputString);
int occurrences = CountOccurrences(inputString, mostFrequentChar);

Console.WriteLine($"The character '{mostFrequentChar}' appears {occurrences} times in the string.");
    

    static char FindMostFrequentCharacter(string inputString)
{    
    inputString = inputString.ToLower();

    Dictionary<char, int> charCount = new Dictionary<char, int>();

    foreach (char c in inputString)
    {
     
        if (char.IsLetter(c))
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }
    }

    
    char mostFrequentChar = charCount.OrderByDescending(x => x.Value).First().Key;

    return mostFrequentChar;
}

static int CountOccurrences(string inputString, char character)
{
    inputString = inputString.ToLower();

    int count = 0;
    foreach (char c in inputString)
    {
        
        if (char.IsLetter(c) && c == character)
        {
            count++;
        }
    }
    return count;
}