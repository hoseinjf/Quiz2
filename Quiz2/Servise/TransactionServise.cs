using Quiz2.Continer;
using Quiz2.Entity;
using Quiz2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.Servise
{
    public class TransactionServise
    {
        private readonly ITransactionRepository _transactionRepository;
        public TransactionServise()
        {
            _transactionRepository = new TransactionRepository();
        }
        public void Transfer(string sourceCard, string destinationCard, float transferAmount)
        {

            _transactionRepository.Transfer(sourceCard, destinationCard, transferAmount);
        }
        public List<Transaction> GetTransactions(string sourceCard)
        {
            var ac = _transactionRepository.GetTransactions(sourceCard);
            foreach (var item in ac) 
            {
                Console.WriteLine($"Source Card Number: {item.SourceCardNumber} -- " +
                    $"Destination Card Number: {item.DestinationCardNumber} -- " +
                    $"Transaction Date: {item.TransactionDate} -- " +
                    $"Amount: {item.Amount} -- " +
                    $"Successful: {item.isSuccessful}");
                Console.WriteLine("-------------------------------------------------------");
            }
            return ac;
        }
    }
}
