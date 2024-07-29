

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


//Ошибка алгоритма, в добавлении элемента с массива который уже используетися.
//Добавить ограничения в ввиде массива с указателями

bool Exist(char[][] board, string word)
{
    for (int i = 0; i < board.Length; i++)
    {
        for (int j = 0; j < board[0].Length; j++)
        {

            if (board[i][j] == word[0])
            {
                char[] wordArray = word.ToCharArray();
                bool flag = helperFunc(board, wordArray, i, j, 0);
                if (flag == true)
                {
                    return true;
                }
            }

        }
    }
    return false;
}

bool helperFunc(char[][] board, char[] word, int i, int j, int cur)
{
    if (cur == word.Length)
    {
        return true;
    }
    if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] != word[cur])
    {
        return false;
    }
    char temp = board[i][j];
    board[i][j] = '$';
    bool a = helperFunc(board, word, i + 1, j, cur + 1);
    bool b = helperFunc(board, word, i - 1, j, cur + 1);
    bool c = helperFunc(board, word, i, j + 1, cur + 1);
    bool d = helperFunc(board, word, i, j - 1, cur + 1);
    board[i][j] = temp;
    return a | b | c | d;

}