using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04Ex02
{
    public class Varejo : Empresa, IOperacoesEmpresa
    //IEnviarNotificacao nao precisa implementar aqui porque no metodo construtor eu injeto através de _enviarNotificacao quando eu criar uma instancia de varejo.
    //Isso é IOC (Inversão de Controle) que tem por objetivo remover as dependências (remover o acoplamento) <- conteúdo da LMS

    {
        // a linha abaixo é para a instancia de um objeto que implementa a interface "IEnviarNotificacao"
        private readonly IEnviarNotificacao _enviarNotificacao;
        public override string Cnpj { get; set; }
        public override string RazaoSocial { get; set; }
        public override string Endereco { get; set; }

        //esse construtor permite que eu injete a implementação de notificação ->
        // quando eu criar uma instancia de varejo.
        public Varejo (IEnviarNotificacao enviarNotificacao)
        {   // recebo interface como parametro
            //Esse processo de injetar a classe no construtor chama-se Injeção de Dependência. 
            _enviarNotificacao = enviarNotificacao;
        }
        public void Imprimir()
        {
            StringBuilder builder = new();
            builder.AppendLine("Impressão Varejo:");
            builder.AppendLine($"CNPJ: {Cnpj}");
            builder.AppendLine($"Razão Social: {RazaoSocial}");
            builder.AppendLine($"Endereço: {Endereco}");

            Console.WriteLine(builder.ToString());
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Realizei venda de produto.");
            
            EnviarMensagemCliente(); 
        }

        //chama o método EnviarMensagemCliente() na instância de IEnviarNotificacao
        // armazenada no campo _enviarNotificacao
        public void EnviarMensagemCliente ()
        {
            _enviarNotificacao.EnviarMensagemCliente();
        }

        /*
        public void RealizarServico()
        {
            Console.WriteLine("Realizei serviço.");
        }
        */
    }
}