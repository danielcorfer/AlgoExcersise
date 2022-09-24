
public class Program
{
    static void Main(string[] args)
    {
        char letter = 'a';
        Console.WriteLine($"{letter.GetType().Name}");

        char letter2 = 'b';
        Console.WriteLine(SameCase(letter, letter2));
    }


   public static int SameCase(char firstLetter, char secondLetter)
    {
        if (!char.IsLetter(firstLetter) || !char.IsLetter(secondLetter))
        {
            return -1;
        }
//IsLower() returns bool => two bools are then compared and return integer
                   
        return char.IsLower(firstLetter) == char.IsLower(secondLetter) ? 1 : 0;
    }
}

