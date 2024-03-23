/*Scrieti un program care va afisa pozitia unui substring intr-un string, ambele
siruri de caractere fiind citite de la tastatura
*/


Console.WriteLine("Enter the main string:");
string mainString = Console.ReadLine();

Console.WriteLine("Enter the substring:");
string subString = Console.ReadLine();

int position = FindSubstringPosition(mainString, subString);

if (position != -1)
{
    Console.WriteLine($"The substring \"{subString}\" is found at position {position} in the main string.");
}
else
{
    Console.WriteLine($"The substring \"{subString}\" is not found in the main string.");
}
    

    static int FindSubstringPosition(string mainString, string subString)
{
    for (int i = 0; i <= mainString.Length - subString.Length; i++)
    {
        bool found = true;
        for (int j = 0; j < subString.Length; j++)
        {
            if (mainString[i + j] != subString[j])
            {
                found = false;
                break;
            }
        }
        if (found)
        {
            return i;
        }
    }
    return -1;
}
