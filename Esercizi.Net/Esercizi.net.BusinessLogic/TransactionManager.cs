
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi.Net.BusinessLogic
{
     public class TransactionManager
    {
        
        public ITransactionFactory Factory { get; }     // è una property
        public List<ITransazione> Transazioni { get; } // per salvare la transazione ci serve una struttura dati d'appoggio, ad esempio una lista o una collezione generica

        public TransactionManager(): this (new TransactionFactory()) // serve per non dare errore, poi ci spiegherà perchè
        {

        }

        public TransactionManager (ITransactionFactory factory)  // è il costruttore (perchè ha lo stesso nome della property)
        {
            Factory = factory;
            Transazioni = new List<ITransazione>();
        }

      
            public ITransazione CreateTransaction ()   // sto creando un metodo che non prende nulla in input, restituisce un risultato del tipo Itransaction 
        {
            return Factory.Create();      // è il corpo. richiamo il metodo create della property factory

        }
        public void SaveTransaction(ITransazione transazione) 
        {
            Transazioni.Add(transazione);
        }
        public ITransazione DeleteTransaction(int index)
        {
            return null;
        }

        public IEnumerable<ITransazione> GetTransactions()    //  IEnumerable: interfaccia degli oggetti  più generica
        {
            return null;
        }




    }
}
