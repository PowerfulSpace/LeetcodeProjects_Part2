

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
    Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
    foreach (string s in strs)
    {
        char[] charArray = s.ToCharArray();
        Array.Sort(charArray);
        string sortedString = new string(charArray);
        if (!dict.ContainsKey(sortedString))
        {
            dict[sortedString] = new List<string>();
        }
        dict[sortedString].Add(s);
    }
    return new List<IList<string>>(dict.Values);
}
