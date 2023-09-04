using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula05ExBiblioteca
{
    public class Biblioteca
    {
        public List<IPodeSerEmprestado> ItensDisponiveis { get; private set; }

        public Biblioteca()
        {
            ItensDisponiveis = new List<IPodeSerEmprestado>();
        }

        public void AdicionarItem(IPodeSerEmprestado item)
        {
            ItensDisponiveis.Add(item);
        }

        public void EmprestarItem(IPodeSerEmprestado item, DateTime dataEmprestimo)
        {
            item.Emprestar(dataEmprestimo);
        }

        public void DevolverItem(IPodeSerEmprestado item, DateTime dataDevolucao)
        {
            item.Devolver(dataDevolucao);
        }
    }
}