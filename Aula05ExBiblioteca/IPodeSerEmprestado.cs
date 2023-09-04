using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula05ExBiblioteca
{
    public interface IPodeSerEmprestado
    {
        void Emprestar(DateTime dataEmprestimo);
        void Devolver(DateTime dataDevolucao);
    }
}