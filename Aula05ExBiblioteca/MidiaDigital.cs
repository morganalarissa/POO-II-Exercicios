using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula05ExBiblioteca
{
    public class MidiaDigital : ItemBiblioteca, IPodeSerEmprestado
    {

        public int CodigoMidia { get; set; }
        public bool Emprestado { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime DataDevolucao { get; private set; }

        public MidiaDigital(int codigo, string titulo, string autor, int anoPublicacao, int numPaginas) : base(titulo, autor, anoPublicacao, numPaginas)
        {

        }
        public string Emprestar(DateTime dataEmprestimo)
        {
            if (!Emprestado)
            {
                Emprestado = true;
                DataEmprestimo = dataEmprestimo;
             
                return $"A midia digital: {Titulo} foi compartilhada em: ({DataEmprestimo.ToShortDateString()})";
            }
            else
            {
                return $"A midia digital: {Titulo}  n�o esta mais dispon�vel para compartilhamento.";
            }
        }

        public string Devolver(DateTime dataDevolucao)
        {      
               return $"Midia Digital n�o tem devolu��o.";          
        }
    }
}