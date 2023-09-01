using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04Ex01
{
    public abstract class Empresa
    {
        public abstract string Cnpj { get; set; }
        public abstract string RazaoSocial {get; set;}
        public abstract string Endereco {get; set;}


        public void Imprimir ()
        {
            Console.WriteLine($" CNPJ: {Cnpj}{Environment.NewLine} Razão Social: {RazaoSocial}{Environment.NewLine} Endereço: {Endereco}");
        }

        public abstract void RealizarVenda();               
    }
}