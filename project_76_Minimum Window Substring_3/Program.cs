
string s1 = "ADOBECODEBANC", t1 = "ABC";
string s2 = "a", t2 = "a";
string s3 = "aa", t3 = "aa";


Console.WriteLine(MinWindow(s1, t1));
Console.WriteLine(MinWindow(s2, t2));
Console.WriteLine(MinWindow(s3, t3));


Console.ReadLine();


string MinWindow(string s, string t)
{
    int[] need = new int[128];
    int[] window = new int[128];
    foreach (var c in t)
    {
        ++need[c];
    }
    int cnt = 0, j = 0, k = -1, mi = 1 << 30;
    for (int i = 0; i < s.Length; ++i)
    {
        ++window[s[i]];
        if (need[s[i]] >= window[s[i]])
        {
            ++cnt;
        }
        while (cnt == t.Length)
        {
            if (i - j + 1 < mi)
            {
                mi = i - j + 1;
                k = j;
            }
            if (need[s[j]] >= window[s[j]])
            {
                --cnt;
            }
            --window[s[j++]];
        }
    }
    return k < 0 ? "" : s.Substring(k, mi);
}

