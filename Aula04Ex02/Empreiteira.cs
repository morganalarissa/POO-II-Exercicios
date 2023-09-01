using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04Ex02
{
    public class Empreiteira : Empresa, IMetodos
    {
        public override string Cnpj { get; set; }
        public override string RazaoSocial { get; set; }
        public override string Endereco { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Impressão Empreiteira:{Environment.NewLine}CNPJ: {Cnpj}{Environment.NewLine}Razão Social: {RazaoSocial}{Environment.NewLine}Endereço: {Endereco}{Environment.NewLine}");
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Realizei venda como Empreiteira");
        }

        public void RealizarServico()
        {
            Console.WriteLine("Realizei serviço como Empreiteira");
        }
    }
}