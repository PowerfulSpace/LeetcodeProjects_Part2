
using System.Text;
using System.Text.RegularExpressions;

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
//Console.WriteLine(SimplifyPath(path3));
//Console.WriteLine(SimplifyPath(path4));
//Console.WriteLine(SimplifyPath(path5));
//Console.WriteLine(SimplifyPath(path6));
//Console.WriteLine(SimplifyPath(path7));
Console.WriteLine(SimplifyPath(path8));


Console.ReadLine();


string SimplifyPath(string path)
{
    string patter = @"/((\.{1,10})?(\w+)(\.{1,10})?(\w+)?)(\.{1,10})?|/(\.{1,10})";
    Regex regex = new Regex(patter);
    var collection = regex.Matches(path);

    List<Match> list = new List<Match>();

    foreach (Match match in collection)
    {
        if(match.Value == "/.") { continue; }
        if (match.Value == "/..")
        {
            if(list.Count > 0)
            {
                list.RemoveAt(list.Count - 1);
            }
        }
        else
        {
            list.Add(match);
        }


    }

    string result = string.Concat(list);

    if(result == "") { result = "/"; }

    return result;
}