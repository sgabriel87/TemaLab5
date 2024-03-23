/*Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din
sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici.
Exemplu:
Input: Ana ARE mErE
Rezultat: Ana Are Mere*/

Console.WriteLine("Enter a string:");
string inputString = Console.ReadLine();

string normalizedString = LowerCasing(inputString);

Console.WriteLine($"Result: {normalizedString}");
    

    static string LowerCasing(string inputString)
{
    
    string[] words = inputString.Split(' ');

    
    string result = "";

    
    foreach (string word in words)
    {
    
        if (!string.IsNullOrEmpty(word))
        {
    
            string normalizedWord = char.ToUpper(word[0]) + word.Substring(1).ToLower();

    
            result += normalizedWord + " ";
        }
    }

    
    result = result.Trim();

    return result;
}