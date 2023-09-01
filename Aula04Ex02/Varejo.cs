using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04Ex02
{
    public class Varejo : Empresa, IOperacoesEmpresa
    {
        public override string Cnpj { get; set; }
        public override string RazaoSocial { get; set; }
        public override string Endereco { get; set; }

        public void Imprimir()
        {
            StringBuilder builder = new();
            builder.AppendLine("Impressão Empreiteira:");
            builder.AppendLine($"CNPJ: {Cnpj}");
            builder.AppendLine($"Razão Social: {RazaoSocial}");
            builder.AppendLine($"Endereço: {Endereco}");

            Console.WriteLine(builder.ToString());
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Realizei venda de produto.");
        }
        /*
        public void RealizarServico()
        {
            Console.WriteLine("Realizei serviço.");
        }
        */
    }
}