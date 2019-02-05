using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi.Net.BusinessLogic
{
    public class TransactionFactory : ITransactionFactory // potevo anche scrivere : IFactory<ITransazione> , non cambia niente
    {
        public ITransazione Create()  // Create è un metodo
        {
            return new TransazioneGK();  // crea TransazioneGK che implementa ITransazione, i miei clienti devono sapere che serve ITransazione, noi restituiamo transazioneGK o transazioneC a nostro piacere
        }                                // chi usa questo metodo sa che recupera un ITransazione, che restituirà un tipo a piacere (GK o C)
    }
}
