

using System.Text;

string[] str1 = { "This", "is", "an", "example", "of", "text", "justification." };
int maxWidth1 = 16;


FullJustify(str1, maxWidth1);

Console.ReadLine();


IList<string> FullJustify(string[] words, int maxWidth)
{
    List<string> result = new List<string>();
    StringBuilder row = new StringBuilder();
    int count = 0;
    foreach (string word in words)
    {
        if (row.Length + word.Length <= maxWidth)
        {
            if (row.Length + 1 + word.Length <= maxWidth)
            {
                row.Append(word + " ");
            }
            else
            {
                row.Append(word);
            }
            count++;
        }
        else
        {
            LineaAlignment(row, maxWidth, count);

            result.Add(row.ToString());
            row.Clear();

            row.Append(word + " ");
            count = 1;
        }
    }
    if (row.Length > 0)
    {
        result.Add(row.ToString());
        row.Clear();
    }


    return result;
}

void LineaAlignment(StringBuilder row, int maxWidth, int elementsCount)
{
    int lengthSpace = maxWidth - row.Length;
    int countSpace = lengthSpace / (elementsCount - 1);

    for (int i = 0; i < maxWidth; i++)
    {
        if (row[i] == ' ')
        {
            row.Insert(i, " ", countSpace);
            i += countSpace;
            lengthSpace -= countSpace;
        }
    }
    Console.WriteLine();
}