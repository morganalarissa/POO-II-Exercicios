/*## Exercício 1

Crie uma classe Empresa que possua os dados básicos de uma empresa como propriedades.
Construa um método para imprimir as informações da empresa.
Construa um método abstrato void RealizarVenda()

Crie uma classe Varejo que implemente o método abstrato para imprimir que vende produtos.
Crie uma classe Empreiteira que implemente o método abstrato para imprimir que vende serviços.

Na main, crie um objeto de cada classe, preenchendo as propriedades e invocando os métodos.*/

using System;

namespace Aula04Ex01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Varejo varejo = new Varejo
            {
                Cnpj = "654848490001",
                RazaoSocial = "House Targaryen",
                Endereco = "Rua Westeros, 500"
            };

            Empreiteira empreiteira = new Empreiteira
            {
                Cnpj = "849844040001",
                RazaoSocial = "House Stark",
                Endereco = "Winterfel, 1000"
            };

           
            varejo.Imprimir();
            varejo.RealizarVenda();

            Console.WriteLine();
  
            empreiteira.Imprimir();
            empreiteira.RealizarVenda();

            Console.ReadKey();
        }    
    }
}
