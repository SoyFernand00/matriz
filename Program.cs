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



