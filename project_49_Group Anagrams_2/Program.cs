

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
    Dictionary<string, IList<string>> result = new();
    foreach (var s in strs)
    {
        var chars = s.ToCharArray();
        Array.Sort(chars);
        var key = new string(chars);
        if (!result.TryAdd(key, new List<string>() { s }))
            result[key].Add(s);
    }
    return result.Values.ToList();
}
