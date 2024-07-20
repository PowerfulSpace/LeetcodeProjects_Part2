

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
        LineaAlignment(row, maxWidth, count);

        result.Add(row.ToString());
        row.Clear();
    }


    return result;
}

void LineaAlignment(StringBuilder row, int maxWidth, int elementsCount)
{
    if (row[row.Length - 1] == ' ')
    {
        row.Length--;
    }

    int needToAddSpace = maxWidth - row.Length;

    if (elementsCount <= 2)
    {
        while (row.Length < maxWidth)
        {
            row.Append(" ");
        }
        return;
    }

    int countSpace = needToAddSpace / (elementsCount - 1);

    if (needToAddSpace < elementsCount)
    {
        countSpace = 1;
    }

    for (int i = 0; i < maxWidth; i++)
    {
        if (row[i] == ' ')
        {
            row.Insert(i, " ", countSpace);
            i += countSpace;
            needToAddSpace -= countSpace;
        }
        if (row.Length == maxWidth) { break; }
    }
}

