using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04Ex02
{
    public interface IOperacoesEmpresa
    {
        void Imprimir ();
        void RealizarVenda ();

        // Obs.: Considerei em implementar um método para realizar serviço, porém a classe "Varejo" seria obrigada a ter e vice-versa na classe "Empreiteira".
        // Então optei por implementar a ação de "venda de serviço/ venda de produto no próprio metodo "RealizarVenda" de cada classe.;
        //void RealizarServico ();

    }
}