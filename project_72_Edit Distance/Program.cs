
using System.Text;

string word1 = "horse";
string word2 = "ros";



Console.WriteLine(MinDistance(word1, word2));

Console.ReadLine();


int MinDistance(string word1, string word2)
{
    StringBuilder sb = new StringBuilder(word1);
    int count = 0;

    for (int i = 0; i < word1.Length; i++)
    {
        if (i >= word2.Length)
        {
            while(sb.Length > word2.Length)
            {
                sb.Length--;
            }
            break;  
        }
        if (sb[i] != word2[i])
        {
            sb[i] = word2[i];
            count++;
        }
    }


    return count;
}
