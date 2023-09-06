using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula05ExBiblioteca
{
    public abstract class ItemBiblioteca
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public int NumPaginas { get; set; }

        protected ItemBiblioteca(string titulo, string autor, int anoPublicacao, int numPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            NumPaginas = numPaginas;
        }


    }
}