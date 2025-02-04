﻿
using System.Text;

string path1 = "/home/";
string path2 = "/home//foo/";
string path3 = "/home/user/Documents/../Pictures";
string path4 = "/../";
string path5 = "/.../a/../b/c/../d/./";
string path6 = "/a/./b/../../c/";
string path7 = "/.../a/../b/c/../d/./";
string path8 = "/../..ga/b/.f..d/..../e.baaeeh./.a";

//Console.WriteLine(SimplifyPath(path1));
//Console.WriteLine(SimplifyPath(path2));
Console.WriteLine(SimplifyPath(path3));
Console.WriteLine(SimplifyPath(path4));
Console.WriteLine(SimplifyPath(path5));
Console.WriteLine(SimplifyPath(path6));
Console.WriteLine(SimplifyPath(path7));
Console.WriteLine(SimplifyPath(path8));


Console.ReadLine();


string SimplifyPath(string path)
{
    var stack = new Stack<string>();
    var sb = new StringBuilder();
    var parts = path.Split('/');

    foreach (var part in parts)
    {
        if (part == "." || part == "")
            continue;
        if (part == "..")
        {
            if (stack.Count > 0)
                stack.Pop();
        }
        else
            stack.Push(part);
    }
    while (stack.Count > 0)
    {
        sb.Insert(0, "/" + stack.Pop());
    }

    return sb.Length == 0 ? "/" : sb.ToString();
}