using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04Ex01
{
    public class Varejo : Empresa
    {
        public override string Cnpj { get; set; }
        public override string RazaoSocial { get; set; }
        public override string Endereco { get; set; }

        public override void Imprimir()
        {
            StringBuilder builder = new();
            builder.AppendLine("Impress�o Varejo:");
            builder.AppendLine();
            builder.AppendLine($"CNPJ: {Cnpj}");
            builder.AppendLine($"Raz�o Social: {RazaoSocial}");
            builder.AppendLine($"Endere�o: {Endereco}");
            Console.WriteLine(builder.ToString());
        }
        public override void RealizarVenda()
        {
            Console.WriteLine("Venda de produtos");
        }
    }
}