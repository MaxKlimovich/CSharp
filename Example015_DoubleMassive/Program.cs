



// string[,] table = new string[2, 5];

// // String.Empty
// // table[0,0]   table[0,1]  table[0,2]  table[0,3]  table[0,4]
// // table[1,0]   table[1,1]  table[1,2]  table[1,3]  table[1,4]
// // table[2,0]   table[2,1]  table[2,2]  table[2,3]  table[2,4]

// table[1, 2] = "слово";

// for (int rows = 0; rows < 3; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }




// void PrintArr(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArr(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1, 10);
//         }
//     }
// }

// int[,] matrix = new int[3, 4];

// PrintArr(matrix);
// FillArr(matrix);
// Console.WriteLine();
// PrintArr(matrix);


//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Окрашивание изображения


int[,] pic = new int[,]
{
    {0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,1,1,1,0,0,1,1,1,0,0,0,0,0,0,0,0},
    {0,1,1,1,1,0,0,1,0,0,1,0,0,1,1,1,0,0,0,0,0},
    {1,0,0,0,1,0,0,1,0,0,1,0,0,1,0,0,1,0,0,0,0},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
};

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
            // Console.Write($"{image[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}
PrintImage(pic);
FillImage(5, 5);
PrintImage(pic);