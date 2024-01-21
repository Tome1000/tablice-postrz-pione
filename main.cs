using System;

class Program
{
    static char[][] ReadJaggedArrayFromStdInput()
    {
        string rows = Console.ReadLine();
        int rowsInt = int.Parse(rows);
        string[] contentArray = new string[rowsInt];
        char[][] tab = new char[rowsInt][];

        for (int a = 0; a <= rowsInt - 1; a++)
        {
            contentArray = Console.ReadLine().Split(' ');
            tab[a] = new char[contentArray.Length];

            for (int b = 0; b <= contentArray.Length - 1; b++)
            {
                tab[a][b] = contentArray[b][0];
            }
        }

    

        return tab;
    }

    static char[][] TransposeJaggedArray(char[][] tab)
    {
        int rows = tab.Length;
        int cols = 0;

        for (int a = 0; a <= rows - 1; a++)
        {

            if (tab[a].Length > cols)
            {
                cols = tab[a].Length;
            }

        }

        char[][] TransposeJaggedArray = new char[cols][];

        for (int a = 0; a < cols; a++)
        {
            TransposeJaggedArray[a] = new char[rows];

            for (int b = 0; b < rows; b++)
            {
                try
                {
                    TransposeJaggedArray[a][b] = tab[b][a];
                }
                catch (IndexOutOfRangeException)
                {

                }
            }
        }


        return TransposeJaggedArray;
    }


    static void PrintJaggedArrayToStdOutput(char[][] tab)
    {
        for (int a = 0; a < tab.Length; a++)
        {
            {
                for (int b = 0; b < tab[a].Length; b++)
                {
                    if (tab[a][b] != '\x00')
                    {
                        Console.Write(tab[a][b] + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
            }
            Console.WriteLine();

        }
    }
}






