namespace G10ExamSaydakhmetova;

internal class Program
{
    static void Main(string[] args)
    {

    }

    //task1
    public static int CountDoubleRoomElement(List<int> numbers)
    {
        var counter = 0;
        foreach (var number in numbers)
        {
            if (10 <= number && number <= 99)
            {
                counter++;
            }
        }
        return counter;
    }

    // task2
    public static string DeleteLastTwoElement(string text)
    {
        var newText = text.Substring(0, text.Length - 2);
        return newText;
    }

    //task3
    public static bool CheckWordFirstUpperLetter(List<string> words)
    {
        var response = false;
        foreach (var word in words)
        {
            if (char.IsLower(word[0]) is true)
            {
                response = false;
                break;
            }
            response = true;
        }
        return response;
    }

    // task4
    public static bool StartAndFinishWithQovun(string text)
    {
        if (text.StartsWith("qovun") && text.EndsWith("qovun") is true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
