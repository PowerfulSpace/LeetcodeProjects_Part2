
int n1 = 4;

SolveNQueens(n1);

Console.ReadLine();

Dictionary<int, char> num;
IList<IList<string>> SolveNQueens(int n)
{
    num = new Dictionary<int, char>()
    {
        [1] = '1',
        [2] = '2',
        [3] = '3',
        [4] = '4',
        [5] = '5',
        [6] = '6',
        [7] = '7',
        [8] = '8',
        [9] = '9'
    };

    var result = new List<IList<string>>();

    char[,] cheasBoard = new char[n, n];

    int countQueens = 0;

    int x = 0;
    int y = 0;

    int left = 0;
    int rigth = 0;

    AccommodationQueens(cheasBoard, y, x, left, rigth, countQueens);

    return result;
}

void AccommodationQueens(char[,] cheasBoard, int y, int x, int left, int rigth, int countQueens)
{
    if (y > cheasBoard.GetLength(0) || x > cheasBoard.GetLength(0)) { return; }
    if (countQueens == cheasBoard.GetLength(0)) { return; }

    bool isAdd = false;


    if (y < cheasBoard.GetLength(1))
    {
        for (int i = 0; i < cheasBoard.GetLength(0); i++)
        {
            if (cheasBoard[y, i] == '\0')
            {
                cheasBoard[y, i] = 'Q';
                x = i;

                isAdd = true;
                countQueens++;

                break;
            }
        }

        if (isAdd)
        {
            left = x - y;
            rigth = x + y;

            LokingCells(cheasBoard, y, x, left, rigth, countQueens);

            Print(cheasBoard);

            AccommodationQueens(cheasBoard, y + 1, 0, left, rigth, countQueens);


            if (countQueens < cheasBoard.GetLength(0))
            {
                int positionX = GetPositionQeen(cheasBoard, y, countQueens);

                DeletePositionQeen(cheasBoard, y, countQueens);

                cheasBoard[y, positionX] = countQueens > 1 ? num[countQueens - 1] : num[1];
                countQueens--;

                Print(cheasBoard);

                AccommodationQueens(cheasBoard, y, positionX + 1, left, rigth, countQueens);
            }

        }

    }

    return;
}

void LokingCells(char[,] cheasBoard, int y, int x, int left, int rigth, int countQueens)
{

    for (int j = 0; j < cheasBoard.GetLength(0); j++, left++, rigth--)
    {

        if (cheasBoard[y, j] != 'Q' && !num.ContainsKey((int)Char.GetNumericValue(cheasBoard[y, j]))) { cheasBoard[y, j] = num[countQueens]; }
        if (cheasBoard[j, x] != 'Q' && !num.ContainsKey((int)Char.GetNumericValue(cheasBoard[j, x]))) { cheasBoard[j, x] = num[countQueens]; }

        if (left >= 0 && left <= cheasBoard.GetLength(1) - 1)
        {
            if (cheasBoard[y, left] != 'Q' && cheasBoard[j, left] != 'Q' && !num.ContainsKey((int)Char.GetNumericValue(cheasBoard[j, left]))) { cheasBoard[j, left] = num[countQueens]; }
        }

        if (rigth <= cheasBoard.GetLength(1) - 1 && rigth >= 0)
        {
            if (cheasBoard[y, rigth] != 'Q' && cheasBoard[j, rigth] != 'Q' && !num.ContainsKey((int)Char.GetNumericValue(cheasBoard[j, rigth]))) { cheasBoard[j, rigth] = num[countQueens]; }
        }
    }
}

int GetPositionQeen(char[,] cheasBoard, int y, int countQueens)
{
    int positionX = 0;

    for (int i = 0; i < cheasBoard.GetLength(0); i++)
    {
        if (cheasBoard[y, i] == 'Q')
        {
            positionX = i;
            break;
        }
    }

    return positionX;
}

int GetFreePosition(char[,] cheasBoard, int y)
{
    int positionX = 0;

    for (int i = 0; i < cheasBoard.GetLength(0); i++)
    {
        if (cheasBoard[y, i] == '\0')
        {
            positionX = i;
            break;
        }
    }

    return positionX;
}


void DeletePositionQeen(char[,] cheasBoard, int y, int countQueens)
{
    char shouldBeRemove = num[countQueens];

    for (int i = y; i < cheasBoard.GetLength(0); i++)
    {
        for (int j = 0; j < cheasBoard.GetLength(1); j++)
        {
            if (cheasBoard[i, j] == shouldBeRemove)
            {
                cheasBoard[i, j] = '\0';
            }
        }
    }
}

void Print(char[,] CheasBoard)
{
    Console.WriteLine();
    for (int i = 0; i < CheasBoard.GetLength(0); i++)
    {
        for (int j = 0; j < CheasBoard.GetLength(1); j++)
        {
            if (CheasBoard[i, j] != '\0')
            {
                Console.Write(CheasBoard[i, j] + " ");
            }
            else
            {
                Console.Write("  ");
            }

        }
        Console.WriteLine();
    }
}

//Добавить условия
//1) Как только получается вся строка забита, и нету места добавить новый, откатываемся назад
//2) Очищаем все числа элеманта связанные с количеством добавленных жлементов
//3) Смещаемся в сторону, добавляем эллемент