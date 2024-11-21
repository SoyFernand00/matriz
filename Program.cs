/*
int Fil = 5;
int col = 3;
int[][] mat = new int[Fil][];


for (int f = 0; f < mat.Length; f++)
{
    mat[f] = new int[col];
}

//ingreso

for (int f = 0; f < mat.Length; f++)
{
    for (int c = 0; c < mat[0].Length; c++)
    {
        Console.WriteLine($"En fila {f}, Ingrese numero: ");
        mat[f][c]=Convert.ToInt32(Console.ReadLine());
    }
}

//salida

for (int f = 0; f < mat.Length; f++)
{
    for (int c = 0; c < mat[0].Length; c++)
    {
        Console.Write($"{mat[f][c]}, ");
    }
    Console.WriteLine();
}
Console.WriteLine();
*/



/*
//bidimensional
Random rnd = new Random();
int a=0, b=0;
int num = rnd.Next(a, b);
int Fil = 5;
int col = 3;
int[][] mat = new int[Fil][];
//ingreso

Console.WriteLine("Minimo: ");
a=int.Parse(Console.ReadLine());
Console.WriteLine("Maximo mas 1 please: ");
b=int.Parse(Console.ReadLine());


for (int f = 0; f < mat.Length; f++)
{
    for (int c = 0; c < mat[0].Length; c++)
    {
        Console.WriteLine($"En fila {f}, Ingrese numero: ");
        mat[f][num] = Convert.ToInt32(Console.ReadLine());
    }
}

//salida

for (int f = 0; f < mat.Length; f++)
{
    for (int c = 0; c < mat[num].Length; c++)
    {
        Console.Write($"{mat[f][c]}, ");
    }
    Console.WriteLine();
}
Console.WriteLine();
*/



Random rnd = new Random();
int a = 0, b = 0;
int num = rnd.Next(a, b);
int Fil = 5;
int col = 3;
int[,] mat = new int[Fil, col];
//ingreso

Console.WriteLine("Minimo: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Maximo: ");
b = int.Parse(Console.ReadLine());


for (int f = 0; f < mat.GetLength(0); f++)
{
    for (int c = 0; c < mat.GetLength(1); c++)
    {
        mat[f, c] = rnd.Next(a, b + 1);
    }
}

//salida

for (int f = 0; f < mat.GetLength(0); f++)
{
    for (int c = 0; c < mat.GetLength(1); c++)
    {
        Console.Write($"{mat[f, c]}, ");
    }
    Console.WriteLine();
}
Console.WriteLine();


for (int f = 0; f < mat.GetLength(0); f++)
{
    int suma = 0;
    for (int c = 0; c < mat.GetLength(1); c++)
    {
        suma = suma + mat[f, c];
    }
    Console.WriteLine($"Suma de fila {f} es {suma}");
}

for (int c = 0; c < mat.GetLength(1); c++)
{
    int suma = 0;
    for (int f = 0; f < mat.GetLength(0); f++)
    {
        suma = suma + mat[f, c];
    }
    Console.WriteLine($"Suma de fila {c} es {suma}");
}


//CLASE PRACTICA

//problema 1
/*
Console.Write("Ingrese # filas : ");
int f=int.Parse(Console.ReadLine());
Console.Write("Ingrese # Columnas: ");
int c=int.Parse(Console.ReadLine());
int[,] matriz=new int[f,c];

Random rnd=new Random();

Console.WriteLine("Matriz generada: ");
for (int i = 0; i < f; i++)
{
    for (int j = 0; j < c; j++)
    {
        matriz[i, j] = rnd.Next(30, 51);
        Console.Write($"{matriz[i, j]} ");
    }
    Console.WriteLine("");
}
*/

//problema 2
/*
Console.Write("Ingrese # matriz : ");
int num = int.Parse(Console.ReadLine());

int[,] matriz = new int[num, num];
int[,] trnaspuesta = new int[num, num];

Random rnd = new Random();

Console.WriteLine("Matriz origin: ");
for (int i = 0; i < num; i++)
{
    for (int j = 0; j < num; j++)
    {
        matriz[i, j] = rnd.Next(40, 51);
        Console.Write($"{matriz[i, j]} ");
    }
    Console.WriteLine("");
}

Console.WriteLine("MATRIZ TRANSPORTE");
for (int i = 0; i < num; i++)
{
    for (int j = 0; j < num; j++)
    {
        trnaspuesta[j,i]=matriz[i,j];
    }
}
for (int i = 0; i < num; i++)
{
    for (int j = 0; j < num; j++)
    {
        Console.Write($"{trnaspuesta[i, j]} ");
    }
    Console.WriteLine("");

}
*/


//PROBLEMA 3
/*
using System;

Console.Write("Ingrese # filas : ");
int f = int.Parse(Console.ReadLine());
Console.Write("Ingrese # Columnas: ");
int c = int.Parse(Console.ReadLine());

int[,] matriz = new int[f, c];
Random rnd = new Random();

int[] suma=new int[c];
Console.WriteLine("Matriz generada: ");
for (int i = 0; i < f; i++)
{
    for (int j = 0; j < c; j++)
    {
        matriz[i, j] = rnd.Next(20, 31);
        Console.Write($"{matriz[i, j]} ");
        suma[j] += matriz[i, j];
    }
    Console.WriteLine("");
}
Console.BackgroundColor = ConsoleColor.Yellow;
for(int i = 0;i < suma.Length; i++)
{
    Console.Write($"{suma[i]} ");
}
Console.ResetColor();
*/