using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula05ExBiblioteca
{
    public abstract class ItemBiblioteca
    {
        public abstract string Titulo { get; set; }
        public abstract string Autor { get; set; }
        public abstract int AnoPublicacao { get; set; }
        public abstract int NumPaginas { get; set; }
    }
}