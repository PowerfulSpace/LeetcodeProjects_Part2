
using System.Text;

string path1 = "/home/";
string path2 = "/home//foo/";
string path3 = "/home/user/Documents/../Pictures";
string path4 = "/../";
string path5 = "/.../a/../b/c/../d/./";
string path6 = "/a/./b/../../c/";
string path7 = "/.../a/../b/c/../d/./";
string path8 = "/../..ga/b/.f..d/..../e.baaeeh./.a";

Console.WriteLine(SimplifyPath(path1));
Console.WriteLine(SimplifyPath(path2));
Console.WriteLine(SimplifyPath(path3));
Console.WriteLine(SimplifyPath(path4));
Console.WriteLine(SimplifyPath(path5));
Console.WriteLine(SimplifyPath(path6));
Console.WriteLine(SimplifyPath(path7));
Console.WriteLine(SimplifyPath(path8));


Console.ReadLine();


string SimplifyPath(string path)
{
    while (path.Contains("//"))
    {
        path = path.Replace("//", "/");
    }
    string[] s = path.Split('/');
    List<string> li = new();
    for (int i = 1; i < s.Length; i++)
    {
        if (s[i] == "..")
        {
            if (li.Count() > 0)
            {
                li.RemoveAt(li.Count() - 1);
            }
        }
        else
        {
            if (s[i] != ".")
            {
                li.Add(s[i]);
            }
        }

    }
    string result = "/";
    for (int i = 0; i < li.Count(); i++)
    {
        result += li[i];
        if (i < li.Count() - 1)
        {
            result += "/";
        }
    }
    if (result.Length > 1 && result[result.Length - 1] == '/')
    {
        result = result.Substring(0, result.Length - 1);
    }
    return result;
}