

using System.Text;

string[] str1 = { "eat", "tea", "tan", "ate", "nat", "bat" };
string[] str2 = { "eat", "tea", "tan", "ate", "nat", "bat" };
string[] str3 = { "eat", "tea", "tan", "ate", "nat", "bat" };

GroupAnagrams(str1);
GroupAnagrams(str2);
GroupAnagrams(str3);


Console.ReadLine();


IList<IList<string>> GroupAnagrams(string[] strs)
{
    if (strs == null || strs.Length == 0) return new List<IList<string>>();
    var countDict = new Dictionary<string, IList<string>>();
    foreach (string str in strs)
    {
        var charList = new char[26];
        foreach (char c in str)
        {
            charList[c - 'a']++;
        }

        // Increase the count as per char
        // foreach (char c in str) count[c - 'a']++;
        StringBuilder sb = new StringBuilder("");
        for (int i = 0; i < 26; i++)
        {
            sb.Append('#');
            sb.Append(charList[i]);
        }

        string key = sb.ToString();

        if (!countDict.ContainsKey(key))
        {
            countDict.Add(key, new List<string> { str });
        }
        else
        {
            countDict[key].Add(str);
        }
    }

    return countDict.Values.ToList();
}
