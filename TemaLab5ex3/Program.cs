
/*Scrieti un program care va numara toate aparitiile unui caracter intr-un sir
de caractere. Atat caracterul cautat cat si sirul de caractere vor fi citite de la
tastatura*/


Console.WriteLine("Enter the string:");
string inputString = Console.ReadLine();

Console.WriteLine("Enter the character to count:");
char characterToCount = Console.ReadLine()[0];

int count = CountOccurrences(inputString, characterToCount);

Console.WriteLine($"The character '{characterToCount}' appears {count} times in the string.");
    

    static int CountOccurrences(string inputString, char character)
{
    int count = 0;
    foreach (char c in inputString)
    {
        if (c == character)
        {
            count++;
        }
    }
    return count;
}
