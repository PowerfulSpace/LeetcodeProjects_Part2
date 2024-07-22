
using System.Text;
using System.Text.RegularExpressions;

string path1 = "/home/";
string path2 = "/home//foo/";
string path3 = "/home/user/Documents/../Pictures";
string path4 = "/../";
string path5 = "/.../a/../b/c/../d/./";

Console.WriteLine(SimplifyPath(path1));
Console.WriteLine(SimplifyPath(path2));
Console.WriteLine(SimplifyPath(path3));
Console.WriteLine(SimplifyPath(path4));
Console.WriteLine(SimplifyPath(path5));


Console.ReadLine();


string SimplifyPath(string path)
{
    string patter = @"/(\w+|\.{3}|\.{2})";
    Regex regex = new Regex(patter);
    var collection = regex.Matches(path);

    StringBuilder sb = new StringBuilder();
    Queue<Match> q = new Queue<Match>();


    foreach (Match match in collection)
    {
        q.Enqueue(match);

        if (match.Value == "..")
        {
            while (q.Count > 2)
            {
                sb.Append(q.Dequeue());
            }
            while (q.Count > 0)
            {
                q.Dequeue();
            }
        }

        
    }

    if(q.Count > 0)
    {
        while (q.Count > 2)
        {
            sb.Append(q.Dequeue());
        }
    }

    return sb.ToString();
}