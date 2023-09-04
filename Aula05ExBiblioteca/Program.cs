/*Crie uma classe abstrata chamada "ItemBiblioteca" que contenha informações comuns a todos os itens, como título, autor, ano de publicação e número de páginas.

Defina uma interface chamada "PodeSerEmprestado" que declare métodos para empréstimo e devolução de itens.

Crie classes concretas para representar diferentes tipos de itens da biblioteca, como "Livro", "Revista" e "MidiaDigital". Essas classes devem herdar da classe abstrata "ItemBiblioteca" e implementar a interface "PodeSerEmprestado" se aplicável (você pode decidir que tipos de itens serão emprestáveis).

Implemente os métodos de empréstimo e devolução de acordo com a natureza do item. Por exemplo, um livro pode ser emprestado por um período definido, enquanto uma mídia digital pode ser emprestada indefinidamente.

Crie uma classe chamada "Biblioteca" que gerencie uma coleção de itens da biblioteca e forneça métodos para emprestar e devolver itens.

Crie instâncias de diferentes tipos de itens da biblioteca e demonstre como eles podem ser emprestados e devolvidos usando a classe "Biblioteca".
*/
using System;

namespace Aula05ExBiblioteca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro
            {
                Titulo = "Harry Potter",
                Autor = "J.K.",
                AnoPublicacao = 2000,
                NumeroPaginas = 1000
            };

            Revista revista = new Revista
            {
                Titulo = "Tititi",
                Autor = "Sonia Abrao",
                AnoPublicacao = 2023,
                NumeroPaginas = 30
            };

            MidiaDigital midia = new MidiaDigital
            {
                Titulo = "CSharp",
                Autor = "Paola",
                
            };
             Biblioteca biblioteca = new Biblioteca();

            
            biblioteca.AdicionarItem(livro);
            biblioteca.AdicionarItem(revista);

            
            DateTime dataEmprestimo = DateTime.Now;
            DateTime dataDevolucao = dataEmprestimo.AddDays(14);

            biblioteca.EmprestarItem(livro, dataEmprestimo);
            biblioteca.DevolverItem(livro, dataDevolucao);

            biblioteca.EmprestarItem(revista, dataEmprestimo);
            biblioteca.DevolverItem(revista, dataDevolucao);

            Console.ReadKey();
        }
    }
}