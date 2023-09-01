/*## Exercício 1

Crie uma classe Empresa que possua os dados básicos de uma empresa como propriedades.
Construa um método para imprimir as informações da empresa.
Construa um método abstrato void RealizarVenda()

Crie uma classe Varejo que implemente o método abstrato para imprimir que vende produtos.
Crie uma classe Empreiteira que implemente o método abstrato para imprimir que vende serviços.

Na main, crie um objeto de cada classe, preenchendo as propriedades e invocando os métodos.

## Exercício 2
Faça o mesmo exercício aplicando Interfaces.
Crie a classe base para herdar as propriedades porém façam os métodos através de implementação de Interface.

Na main, crie uma lista de interface.
Adicione um objeto de cada classe do tipo da interface, preenchendo as propriedades
Invoque os métodos da lista.
*/
using System;
using System.Reflection;

namespace Aula04Ex02
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IOperacoesEmpresa> listaInterface = new();

            Varejo varejo = new Varejo
            {
                Cnpj = "48484840001",
                RazaoSocial = "House Targaryen Ltda",
                Endereco = "Westeros, 1000"
            };

            Empreiteira empreiteira = new Empreiteira
            {
                Cnpj = "84084840001",
                RazaoSocial = "House Stark",
                Endereco = "Wintefell, 150"
            };

            listaInterface.Add(varejo);
            listaInterface.Add(empreiteira);

            foreach (var item in listaInterface)
            {
                item.Imprimir();
                item.RealizarVenda();
                //item.RealizarServico();
                Console.WriteLine(); 
                Console.ReadKey();
            }
            // obs: Tentei usar (reflection) aqui, mas optei por usar diretamente a opção acima.

            /*
            foreach (var item in listaInterface)
            {
                Type tipo = item.GetType();
                MethodInfo[] metodos = tipo.GetMethods(BindingFlags.Public | BindingFlags.Instance);

                foreach (MethodInfo metodo in metodos)
                {
                    if (metodo.Name == "Imprimir" || metodo.Name == "RealizarVenda")
                    {
                        metodo.Invoke(item, null);
                    }
                }

                Console.WriteLine();
            }
            */
            

        }
    }
}

