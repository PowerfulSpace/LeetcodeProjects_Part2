

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
    List<IList<string>> result = new List<IList<string>>();

    Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

    foreach (string str in strs)
    {
        string word = string.Concat(str.Order().ToArray());

        if(dict.ContainsKey(word))
        {
            dict[word].Add(str);
        }
        else
        {
            List<string> list = new List<string>();
            list.Add(str);
            dict.Add(word, list);
        }

        
    }

    result.AddRange(dict.Values);

    return result;
}
