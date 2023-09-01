using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04Ex01
{
    public class Empreiteira : Empresa
    {
        public override string Cnpj { get; set; }
        public override string RazaoSocial { get; set; }
        public override string Endereco { get; set; }

        public override void RealizarVenda()
        {
            Console.WriteLine("Vendendo serviços");
        }
    }
}