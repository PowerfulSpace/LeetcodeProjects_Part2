
string s1 = "ADOBECODEBANC", t1 = "ABC";
string s2 = "a", t2 = "a";
string s3 = "aa", t3 = "aa";


Console.WriteLine(MinWindow(s1, t1));
Console.WriteLine(MinWindow(s2, t2));
Console.WriteLine(MinWindow(s3, t3));


Console.ReadLine();


string MinWindow(string s, string t)
{

    int[] res = new int[2];
    int l = 0, r = 0, reslen = s.Length * 2, i, j;
    Dictionary<char, int> dicts = new Dictionary<char, int>();
    Dictionary<char, int> dictt = new Dictionary<char, int>();
    int have = 0, need = 0;

    foreach (char c in t)
    {
        if (!dictt.ContainsKey(c))
        {
            dictt.Add(c, 1);
            need++;
        }
        else
            dictt[c]++;
    }

    while (r < s.Length)
    {
        if (!dicts.ContainsKey(s[r]))
            dicts.Add(s[r], 1);
        else
            dicts[s[r]]++;

        if (dictt.ContainsKey(s[r]) && dictt[s[r]] == dicts[s[r]])
            have++;

        while (have == need)
        {
            if (reslen > r - l + 1)
            {
                res[0] = l;
                res[1] = r;
                reslen = r - l + 1;
            }

            dicts[s[l]]--;
            if (dictt.ContainsKey(s[l]) && dictt[s[l]] > dicts[s[l]])
                have--;
            l++;
        }
        r++;
    }
    if (reslen != 2 * s.Length)
        return s.Substring(res[0], res[1] - res[0] + 1);
    return "";
}

