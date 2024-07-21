

using System.Text;

string[] str1 = { "This", "is", "an", "example", "of", "text", "justification." };
int maxWidth1 = 16;

string[] str2 = { "The", "important", "thing", "is", "not", "to", "stop", "questioning.", "Curiosity", "has", "its", "own", "reason", "for", "existing." };
int maxWidth2 = 17;

string[] str3 = { "Here", "is", "an", "example", "of", "text", "justification." };
int maxWidth3 = 15;

//FullJustify(str1, maxWidth1);
//FullJustify(str2, maxWidth2);
FullJustify(str3, maxWidth3);

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
            LineaAlignment(row, maxWidth, count, false);

            result.Add(row.ToString());
            row.Clear();

            row.Append(word + " ");
            count = 1;
        }
    }

    if (row.Length > 0)
    {
        LineaAlignment(row, maxWidth, count, true);

        result.Add(row.ToString());
        row.Clear();
    }


    return result;
}

void LineaAlignment(StringBuilder row, int maxWidth, int elementsCount, bool lastLine)
{
    if (row[row.Length - 1] == ' ')
    {
        row.Length--;
    }

    int needToAddSpace = maxWidth - row.Length;

    if (elementsCount == 1 || lastLine == true)
    {
        row.Append(new string(' ',needToAddSpace));

        return;
    }

    int countSpace = needToAddSpace / (elementsCount - 1);

    if (needToAddSpace < elementsCount)
    {
        countSpace = 1;
    }

    while (row.Length < maxWidth)
    {
        for (int i = 0; i < maxWidth; i++)
        {
            if (row.Length - 1 > i && row[i] == ' ')
            {
                row.Insert(i, " ", countSpace);
                i += countSpace;
                needToAddSpace -= countSpace;
            }
            if (row.Length >= maxWidth) { break; }
        }
        countSpace = 1;
    }
}