using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingoc
{
    public class BingoJatekos
    {
        string[,] tabla;
        string nev;
        string[,] talalatok;

        public BingoJatekos(string[,] tabla, string nev)
        {
            this.Tabla = tabla;
            this.Nev = nev;
        }

        public string[,] Tabla { get => tabla; set => tabla = value; }
        public string Nev { get => nev; set => nev = value; }
        public string[,] Talalatok { get => talalatok; set => talalatok = value; }
    }
}
