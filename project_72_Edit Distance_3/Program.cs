

string word1 = "horse";
string word2 = "ros";

string word3 = "intention";
string word4 = "execution";


Console.WriteLine(MinDistance(word1, word2));
Console.WriteLine(MinDistance(word3, word4));

Console.ReadLine();

int MinDistance(string word1, string word2)
{
    int?[][] memo = new int?[word1.Length + 1][];

    for (int i = 0; i <= word1.Length; i++)
        memo[i] = new int?[word2.Length + 1];

    return MinDistanceRecur(memo, word1, word2, word1.Length, word2.Length);
}

int MinDistanceRecur(int?[][] array, string w1, string w2, int index1, int index2)
{
    if (index1 == 0) { return index2; }       
    if (index2 == 0) { return index1; }        
    if (array[index1][index2] != null) { return array[index1][index2].Value; }
        
    int minEditDistance = 0;

    if (w1[index1 - 1] == w2[index2 - 1])
    {
        minEditDistance = MinDistanceRecur(array, w1, w2, index1 - 1, index2 - 1);
    }
    else
    {
        int insertOperation = MinDistanceRecur(array, w1, w2, index1, index2 - 1);

        int deleteOperation = MinDistanceRecur(array, w1, w2, index1 - 1, index2);

        int replaceOperation = MinDistanceRecur(array, w1, w2, index1 - 1, index2 - 1);

        minEditDistance = Math.Min(insertOperation, Math.Min(deleteOperation, replaceOperation)) + 1;
    }

    array[index1][index2] = minEditDistance;
    return minEditDistance;
}