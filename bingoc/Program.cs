// See https://aka.ms/new-console-template for more information
using bingoc;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");
var filename = File.ReadAllLines("nevek.text");
List<BingoJatekos> lines = new List<BingoJatekos>();
{

    foreach (var file in filename)
    {
        string[] fajl = File.ReadAllLines(file);
        string[,] tabla = new string[5,5];
        for (int i = 0; i < 5; i++)
        {
            string[] adatok = fajl[i].Split(';');
            for (int j = 0; j < 5; j++)
            {
                tabla[i,j] = adatok[j];
            }
        }
        BingoJatekos bj = new BingoJatekos(tabla,filename.ToString());
        lines.Add(bj);
    }

    Console.WriteLine($"darab: {lines.Count()}");
}