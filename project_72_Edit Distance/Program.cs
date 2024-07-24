

string word1 = "horse";
string word2 = "ros";

string word3 = "intention";
string word4 = "execution";


Console.WriteLine(MinDistance(word1, word2));
Console.WriteLine(MinDistance(word3, word4));

Console.ReadLine();

int MinDistance(string word1, string word2)
{
    int[,] array = new int[word2.Length + 1, word1.Length + 1];
    FillingTheEdges(array);

    for (int row = 1; row < array.GetLength(0); row++)
    {
        for (int col = 1; col < array.GetLength(1); col++)
        {
            if (word2[row - 1] == word1[col - 1])
            {
                array[row, col] = array[row - 1, col - 1];
            }
            else
            {
                array[row, col] = Math.Min(array[row - 1, col - 1], Math.Min(array[row - 1, col], array[row, col - 1])) + 1;
            }
        }
    }


    return array[array.GetLength(0) - 1, array.GetLength(1) - 1];
}

void FillingTheEdges(int[,] array)
{
    for (int i = 1; i < array.GetLength(1); i++)
    {
        array[0, i] = i;
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, 0] = i;
    }
}
