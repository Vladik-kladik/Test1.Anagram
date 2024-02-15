namespace Test1_Anagram;

public class Anagram
{
        public string ReversedWord(string userinput)
    {

        if (userinput == null)
        {
            return null;
        }

        char[] charArray = userinput.ToCharArray();

        int start = 0;
        int end = charArray.Length - 1;


        while (start < end)
        {
            char temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;

            start++;
            end--;
        }

        return new string(charArray);

    }

    public string Reverse(string userinput)
    {
        if (userinput == null)
        {
            return null;
        }

        string[] natureWords = userinput.Split(' ');

        foreach (var word in natureWords)
        {
            int index = Array.IndexOf(natureWords, word);

            natureWords[index] = Reverse(word);
        }

        return string.Join(" ", natureWords);
    }
}
