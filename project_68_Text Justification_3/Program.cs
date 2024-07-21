

using System.Text;

string[] str1 = { "This", "is", "an", "example", "of", "text", "justification." };
int maxWidth1 = 16;

string[] str2 = { "The", "important", "thing", "is", "not", "to", "stop", "questioning.", "Curiosity", "has", "its", "own", "reason", "for", "existing." };
int maxWidth2 = 17;

string[] str3 = { "Here", "is", "an", "example", "of", "text", "justification." };
int maxWidth3 = 15;

FullJustify(str1, maxWidth1);
FullJustify(str2, maxWidth2);
FullJustify(str3, maxWidth3);

Console.ReadLine();


IList<string> FullJustify(string[] words, int maxWidth)
{
    IList<string> ans = new List<string>();
    List<string> currentLine = new List<string>();
    int currentLineLength = 0;

    for (int i = 0; i < words.Length; i++)
    {
        string word = words[i];

        // Check if adding the new word exceeds the maxWidth
        if (currentLineLength + word.Length + currentLine.Count > maxWidth)
        {
            // If it exceeds, justify the current line and add it to the result
            ans.Add(JustifyLine(currentLine, currentLineLength, maxWidth));
            currentLine.Clear();
            currentLineLength = 0;
        }

        // Add the word to the current line
        currentLine.Add(word);
        currentLineLength += word.Length;
    }

    // Handle the last line (left-justified)
    if (currentLine.Count > 0)
    {
        StringBuilder sb = new StringBuilder();
        foreach (string word in currentLine)
        {
            if (sb.Length > 0) sb.Append(' ');
            sb.Append(word);
        }
        sb.Append(' ', maxWidth - sb.Length); // Pad the end with spaces
        ans.Add(sb.ToString());
    }

    return ans;
}

string JustifyLine(List<string> words, int currentLineLength, int maxWidth)
{
    int totalSpaces = maxWidth - currentLineLength;
    int gaps = words.Count - 1;
    StringBuilder sb = new StringBuilder();

    if (gaps == 0)
    {
        // If there's only one word, left-justify it
        sb.Append(words[0]);
        sb.Append(' ', totalSpaces);
    }
    else
    {
        int spaceWidth = totalSpaces / gaps;
        int extraSpaces = totalSpaces % gaps;

        for (int i = 0; i < words.Count; i++)
        {
            if (i > 0)
            {
                int spacesToApply = spaceWidth + (i <= extraSpaces ? 1 : 0);
                sb.Append(' ', spacesToApply);
            }
            sb.Append(words[i]);
        }
    }

    return sb.ToString();
}