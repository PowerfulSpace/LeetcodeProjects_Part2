
string s1 = "ADOBECODEBANC", t1 = "ABC";
string s2 = "a", t2 = "a";
string s3 = "aa", t3 = "aa";
string s4 = "a", t4 = "b";
string s5 = "cabwefgewcwaefgcf", t5 = "cae";


//Console.WriteLine(MinWindow(s1, t1));
//Console.WriteLine(MinWindow(s2, t2));
//Console.WriteLine(MinWindow(s3, t3));
//Console.WriteLine(MinWindow(s4, t4));
Console.WriteLine(MinWindow(s5, t5));


Console.ReadLine();


string MinWindow(string s, string t)
{
    if(s.Length < t.Length) { return ""; }

    int[] target = new int[128];
    int[] window = new int[128];

    for (int i = 0; i < t.Length; i++)
    {
        target[t[i]]++;
    }
    int min = int.MaxValue;
    int length = 0;

    int index = 0;
    int head = -1;

    for (int i = 0; i < s.Length; i++)
    {
        window[s[i]]++;

        if (target[s[i]] >= window[s[i]])
        {
            length++;
        }

        while (length == t.Length)
        {
            if(min > (i + 1) - index)
            {
                min = (i + 1) - index;
                head = index;
            }

            window[s[index]]--;

            if (target[s[index]] > window[s[index]])
            {
                length--;
            }

            index++;
        }
    }

    return head == - 1 ? "" : s.Substring(head, min);
}

