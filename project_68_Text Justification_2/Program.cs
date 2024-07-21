

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
    var res = new List<string>();
    var cur = new List<string>();
    int num_of_letters = 0;

    foreach (var word in words)
    {
        if (word.Length + cur.Count + num_of_letters > maxWidth)
        {
            for (int i = 0; i < maxWidth - num_of_letters; i++)
            {
                cur[i % (cur.Count - 1 > 0 ? cur.Count - 1 : 1)] += " ";
            }
            res.Add(string.Join("", cur));
            cur.Clear();
            num_of_letters = 0;
        }
        cur.Add(word);
        num_of_letters += word.Length;
    }

    string lastLine = string.Join(" ", cur);
    while (lastLine.Length < maxWidth) lastLine += " ";
    res.Add(lastLine);

    return res;
}
