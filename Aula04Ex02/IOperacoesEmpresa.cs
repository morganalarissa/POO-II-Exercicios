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

        // Obs.: Considerei em implementar um m�todo para realizar servi�o, por�m a classe "Varejo" seria obrigada a ter e vice-versa na classe "Empreiteira".
        // Ent�o optei por implementar a a��o de "venda de servi�o/ venda de produto no pr�prio metodo "RealizarVenda" de cada classe.;
        //void RealizarServico ();

    }
}