
string path1 = "/home/";
string path2 = "/home//foo/";
string path3 = "/home/user/Documents/../Pictures";
string path4 = "/../";
string path5 = "/.../a/../b/c/../d/./";
string path6 = "/a/./b/../../c/";
string path7 = "/.../a/../b/c/../d/./";
string path8 = "/../..ga/b/.f..d/..../e.baaeeh./.a";

//Console.WriteLine(SimplifyPath(path1));
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
    Stack<string> stack = new Stack<string>();
    var split = path.Split('/');
    for (int i = 1; i < split.Count(); i++)
    {
        if (split[i].Length == 0)
            continue;
        if (split[i].Length == 1 && split[i][0] == '.')
        {
            Console.WriteLine($"Split1 = {split[i]}");
            continue;
        }

        else if (split[i].Length == 2 && split[i][0] == '.' && split[i][1] == '.')
        {

            Console.WriteLine($"Split2 = {split[i]}");
            if (stack.Count() > 0)
                stack.Pop();
        }

        else
        {
            Console.WriteLine($"Pushing = {split[i]}");
            stack.Push(split[i]);
        }

    }

    return "/" + String.Join("/", stack.Reverse());
}