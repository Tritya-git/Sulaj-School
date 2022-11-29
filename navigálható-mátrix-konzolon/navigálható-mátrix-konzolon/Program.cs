﻿// mátrix
int[,] matr = new int[5, 5];
// random generálás
Random r = new Random();
// a fő loop futásáért felel
bool run = true;

// sorok indexe
int row = 0;
// oszlopok indexe
int column = 0;
// billentyű lenyomás ellenörzése
bool input = false;

// mátrix feltöltése random számokkal
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        matr[i, j] = r.Next(1, 11);
    }
}
// első generálás (1* fut le) 
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (i == row && j == column)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(String.Format("{0,4}", $"{matr[i, j]}"));
            Console.ResetColor();
        }
        else
        {
            Console.Write(String.Format("{0,4}", $"{matr[i, j]}"));
        }
    }
    Console.WriteLine();
}
Console.WriteLine("------------------------");
// fő kód rész (végtelen* fut le)
while (run == true)
{
    input = false;
    ConsoleKeyInfo k = Console.ReadKey();

    while (input != true)
    {
        switch (k.Key)
        {
            case ConsoleKey.UpArrow:
                if (row > 0)
                {
                    row -= 1;
                }
                Console.Clear(); input = true; break;
            case ConsoleKey.DownArrow:
                if (row < 4)
                {
                    row += 1;
                }
                Console.Clear(); input = true; break;
            case ConsoleKey.LeftArrow:
                if (column > 0)
                {
                    column -= 1;
                }
                Console.Clear(); input = true; break;
            case ConsoleKey.RightArrow:
                if (column < 4)
                {
                    column += 1;
                }
                Console.Clear(); input = true; break;
        }
    }
    // ismétlődő generálás szinezéssel 
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (i == row && j == column)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(String.Format("{0,4}", $"{matr[i, j]}"));
                Console.ResetColor();
            }
            else
            {
                Console.Write(String.Format("{0,4}", $"{matr[i, j]}"));
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("------------------------");
}