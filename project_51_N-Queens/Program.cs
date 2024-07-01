
int n1 = 9;

SolveNQueens(n1);

Console.ReadLine();

IList<IList<string>> SolveNQueens(int n)
{
    var result = new List<IList<string>>();

    char[,] CheasBoard = new char[n,n];

    int x = 0;
    int y = 0;

    for (int i = 0; i < CheasBoard.GetLength(0); i++)
    {
        for (int j = 0; j < CheasBoard.GetLength(1); j++)
        {
            if(CheasBoard[i, j] == '.') { continue; };

            if (CheasBoard[i, j] != '.' && CheasBoard[i, j] != 'Q')
            {
                CheasBoard[i, j] = 'Q';
               
                y = i;
                x = j;

                break;
            }
        }

        int left = x - y;
        int rigth = x + y;


        for (int j = 0; j < CheasBoard.GetLength(0); j++)
        {
            if (CheasBoard[y, j] != 'Q') { CheasBoard[y, j] = '.'; }
            if (CheasBoard[j, x] != 'Q') { CheasBoard[j, x] = '.'; }

            if(left >= 0 && left <= CheasBoard.GetLength(1) - 1)
            {
                if (CheasBoard[y, left] != 'Q') { CheasBoard[j, left] = '.'; } 
            }
            left++;

            if (rigth <= CheasBoard.GetLength(1) - 1 && rigth >= 0)
            {
                if (CheasBoard[y, rigth] != 'Q') { CheasBoard[j, rigth] = '.'; }
            }
            rigth--;
        }
    }

    AccommodationQueens(CheasBoard,0,0);

    return result;
}

void AccommodationQueens(char[,] CheasBoard, int y, int x)
{
    //Добавить рекурсивный метод, для откатывания назад вигур.
    //Откатанная фигура, должна будет сместиться на следующий свободный лемент в право
}