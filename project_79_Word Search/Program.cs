
char[][] board1 = new char[3][]
{
    new char[4] { 'A', 'B', 'C', 'E' },
    new char[4] { 'S', 'F', 'C', 'S' },
    new char[4] { 'A', 'D', 'E', 'E' }
};
string word1 = "ABCCED";

char[][] board2 = new char[3][]
{
    new char[4] {'A', 'B', 'C', 'E'},
    new char[4] {'S', 'F', 'C', 'S'},
    new char[4] { 'A', 'D', 'E', 'E'}
};
string word2 = "SEE";

char[][] board3 = new char[3][]
{
    new char[4] {'A', 'B', 'C', 'E'},
    new char[4] {'S', 'F', 'C', 'S'},
    new char[4] {'A', 'D', 'E', 'E'}
};
string word3 = "ABCB";


Console.WriteLine(Exist(board1, word1));
Console.WriteLine(Exist(board2, word2));
Console.WriteLine(Exist(board3, word3));


Console.ReadLine();





bool Exist(char[][] board, string word)
{

    (int, int) start = (0, 0);
    List<char> result = new List<char>();

    while(start != (-1, -1))
    {
        start = FindTheFirstLitter(board, word[0], start.Item1, start.Item2, result);

        WordSerach(board, 1, start.Item1, start.Item2, result, word);
    }

    if (result.Count != word.Length) { return false; }

    return true;
}


void WordSerach(char[][] board,int index, int y, int x, List<char> litters, string word)
{
    if(litters.Count == word.Length) { return; }

    if(x < 0 || x > board[0].Length - 1 || y < 0 || y > board.Length - 1) {  return; }

    if (x - 1 >= 0 && word[index] == board[y][x - 1])
    {
        litters.Add(word[index]);
        WordSerach(board, index + 1, y, x - 1, litters, word);
        litters.RemoveAt(litters.Count - 1);
    }
    else if (y - 1 >= 0 && word[index] == board[y - 1][x])
    {
        litters.Add(word[index]);
        WordSerach(board, index + 1, y - 1, x, litters, word);
        litters.RemoveAt(litters.Count - 1);
    }
    else if (x + 1 < board[0].Length && word[index] == board[y][x + 1])
    {
        litters.Add(word[index]);
        WordSerach(board, index + 1, y, x + 1, litters, word);
        litters.RemoveAt(litters.Count - 1);
    }
    else if (y + 1 < board.Length && word[index] == board[y + 1][x])
    {
        litters.Add(word[index]);
        WordSerach(board, index + 1, y + 1, x, litters, word);
        litters.RemoveAt(litters.Count - 1);
    }
}

(int,int) FindTheFirstLitter(char[][] board, char litter,int y, int x, List<char> result)
{
    result.Clear();
    for (int i = y; i < board.Length; i++)
    {
        for (int j = x; j < board[i].Length; j++)
        {
            if (board[i][j] == litter)
            {
                result.Add(board[i][j]);
                return (i, j);
            }
        }
    }
    return (-1, -1);
}