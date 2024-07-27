
string s1 = "ADOBECODEBANC", t1 = "ABC";
string s2 = "a", t2 = "a";
string s3 = "aa", t3 = "aa";
string s4 = "a", t4 = "b";
string s5 = "cabwefgewcwaefgcf", t5 = "cae";


Console.WriteLine(MinWindow(s1, t1));
Console.WriteLine(MinWindow(s2, t2));
Console.WriteLine(MinWindow(s3, t3));
Console.WriteLine(MinWindow(s4, t4));
Console.WriteLine(MinWindow(s5, t5));


Console.ReadLine();


string MinWindow(string s, string t)
{
    if (s.Length < t.Length) return string.Empty;

    int[] map = new int[128];
    int count = t.Length;
    int start = 0, end = 0, minStart = 0, minLen = Int32.MaxValue;

    foreach (char c in t) map[c]++;

    while (end < s.Length)
    {
        if (map[s[end++]]-- > 0) count--;

        while (count == 0)
        {
            if (end - start < minLen)
            {
                minStart = start;
                minLen = end - start;
            }

            if (map[s[start++]]++ == 0) count++;
        }
    }

    return minLen == Int32.MaxValue ? string.Empty : s.Substring(minStart, minLen);
}

