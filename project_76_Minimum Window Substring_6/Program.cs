
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
    var dictionary = new int[128];

    foreach (var c in t)
    {
        dictionary[c]++;
    }

    var count = t.Length;
    var left = 0;
    var right = 0;
    var minLeft = 0;
    var minRight = s.Length;

    while (s.Length > right)
    {
        dictionary[s[right]]--;

        if (dictionary[s[right]] >= 0)
        {
            count--;
        }

        while (1 > count)
        {
            if (minRight - minLeft > right - left)
            {
                minLeft = left;

                minRight = right;
            }

            dictionary[s[left]]++;

            if (dictionary[s[left]] > 0)
            {
                count++;
            }

            left++;
        }

        right++;
    }

    if (minRight == s.Length)
    {
        return "";
    }

    return s.Substring(minLeft, minRight - minLeft + 1);
}

