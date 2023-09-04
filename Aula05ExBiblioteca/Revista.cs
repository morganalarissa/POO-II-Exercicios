using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula05ExBiblioteca
{
    public class Revista : ItemBiblioteca, IPodeSerEmprestado
    {
        
        public int CodigoRevista { get; set; }
        public bool Emprestado { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime DataDevolucao { get; private set; }

        public Revista(int codigo, string titulo, string autor, int anoPublicacao, int numPaginas)
        {
            CodigoRevista = codigo;
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            NumPaginas = numPaginas;
        }

        public void Emprestar(DateTime dataEmprestimo)
        {
            if (!Emprestado)
            {
                Emprestado = true;
                DataEmprestimo = dataEmprestimo;
                DataDevolucao = dataEmprestimo.AddDays(30);

                Console.WriteLine($"Revista: {Titulo} foi emprestado em {DataEmprestimo}.{Environment.NewLine}Data de devolução prevista para: {DataDevolucao}.");
            }
            else
            {
                Console.WriteLine($"Revista: {Titulo} já foi emprestado.");
            }
        }

        public void Devolver(DateTime dataDevolucao)
        {
            if (Emprestado)
            {
                Emprestado = false;
                DataDevolucao = dataDevolucao;
                Console.WriteLine($"Revista: {Titulo} foi devolvida em: {DataDevolucao}.");
            }
        }
        
    }
}