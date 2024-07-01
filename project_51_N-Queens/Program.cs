
int n1 = 4;

SolveNQueens(n1);

Console.ReadLine();


// Решить вопрос, с бесконечным циклом


IList<IList<string>> SolveNQueens(int n)
{
    var result = new List<IList<string>>();

    char[,] CheasBoard = new char[n,n];

    int countQueens = 0;

    int x = 0;
    int y = 0;

    int left = 0;
    int rigth = 0;

  
    AccommodationQueens(CheasBoard,y,x,left,rigth, countQueens);

    return result;
}

bool AccommodationQueens(char[,] CheasBoard, int y, int x, int left, int rigth, int countQueens)
{
    if(y > CheasBoard.GetLength(0) || x > CheasBoard.GetLength(0))
    {
        return true;
    }

    if (countQueens == CheasBoard.GetLength(0))
    {
        return true;
    }
    bool isAdd = false;

    if (y < CheasBoard.GetLength(1))
    {
        for (int j = 0; j < CheasBoard.GetLength(0); j++)
        {
            if (CheasBoard[y, j] == '.') { continue; };

            if (CheasBoard[y, j] != '.' && CheasBoard[y, j] != 'Q')
            {
                CheasBoard[y, j] = 'Q';
                isAdd = true;
                x = j;

                break;
            }
        }

        if (isAdd == false) { return false; }

        left = x - y;
        rigth = x + y;

        LokingCells(CheasBoard, y, x, left, rigth);

        Print(CheasBoard);


        bool result = AccommodationQueens(CheasBoard, y + 1, x, left, rigth, countQueens);

        if (result == false)
        {
            CheasBoard[y, x] = '\0';
            AccommodationQueens(CheasBoard, y, x + 1, left, rigth, countQueens);
        }
    }

    return true;
}

void LokingCells(char[,] CheasBoard, int y, int x, int left, int rigth)
{
    
    for (int j = 0; j < CheasBoard.GetLength(0); j++)
    {
        if (CheasBoard[y, j] != 'Q') { CheasBoard[y, j] = '.'; }
        if (CheasBoard[j, x] != 'Q') { CheasBoard[j, x] = '.'; }

        if (left >= 0 && left <= CheasBoard.GetLength(1) - 1)
        {
            if (CheasBoard[y, left] != 'Q' && CheasBoard[j, left] != 'Q') { CheasBoard[j, left] = '.'; }
        }
        left++;

        if (rigth <= CheasBoard.GetLength(1) - 1 && rigth >= 0)
        {
            if (CheasBoard[y, rigth] != 'Q' && CheasBoard[j, rigth] != 'Q') { CheasBoard[j, rigth] = '.'; }
        }
        rigth--;
    }
}


//Добавить рекурсивный метод, для откатывания назад вигур.
//Откатанная фигура, должна будет сместиться на следующий свободный лемент в право


void Print(char[,] CheasBoard)
{
    for (int i = 0; i < CheasBoard.GetLength(0); i++)
    {
        for (int j = 0; j < CheasBoard.GetLength(1); j++)
        {
            Console.Write(CheasBoard[i,j] + " ");
        }
        Console.WriteLine();
    }
}