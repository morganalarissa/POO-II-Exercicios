using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04Ex02
{
    public class EnviarNotificacaoWhatsApp : IEnviarNotificacao
    {
        public void EnviarMensagemCliente ()
        {
            Console.WriteLine("Estou enviando uma mensagem no WhatsApp do Cliente!");
        }
    }
}