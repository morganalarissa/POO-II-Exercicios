/*

## Exercício 2
Faça o mesmo exercício aplicando Interfaces.
Crie a classe base para herdar as propriedades porém façam os métodos através de implementação de Interface.

Na main, crie uma lista de interface.
Adicione um objeto de cada classe do tipo da interface, preenchendo as propriedades
Invoque os métodos da lista.

2 parte do exercício. (aula05) -> 
Vamos pegar o projeto de vcs da Empresa com interfaces!
Crie uma interface EnviarNotificacao com um método void EnviarMensagemCliente.
Crie uma classe EnviarNotificacaoWhatsApp, que implementa EnviarNotificacao e nela teremos o método EnviarMensagemCliente que printa a notificação: "Estou enviando uma mensagem no WhatsApp do Cliente!";

Dentro da classe Varejo, vamos incluir um private readonly EnviarNotificacaoWhatsApp que é recebido no construtor da classe.
Após Realizar a venda, utilizaremos o método de EnviarNotificacao.
*/
using System;
using System.Reflection;

namespace Aula04Ex02
{
    public class Program
    {
        static void Main(string[] args)
        {
            //criei uma instância da classe EnviarNotificacaoWhatsApp e 
            //armazenei em uma variável do tipo IEnviarNotificacao
            IEnviarNotificacao enviarNotificacao = new EnviarNotificacaoWhatsApp();

            List<IOperacoesEmpresa> listaInterface = new();
            
            Varejo varejo = new Varejo(enviarNotificacao)
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

