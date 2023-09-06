using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula05ExBiblioteca
{
    public interface IPodeSerEmprestado
    {
        string Emprestar(DateTime dataEmprestimo);
        string Devolver(DateTime dataDevolucao);
    }
}