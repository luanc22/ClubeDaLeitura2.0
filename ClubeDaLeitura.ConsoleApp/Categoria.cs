using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Categoria
    {
        static int id;
        public int idCategoria;
        public string nome;
        public int diasAEmprestar;
        public Revista[] revistas;

        public Categoria()
        {
            id++;
            idCategoria = id;
        }
    }
}
