using Quiz2.Context;
using Quiz2.Continer;
using Quiz2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly AppDbContext appDbContext;
        public TransactionRepository()
        {
            appDbContext = new AppDbContext();
        }
        public void Transfer(string sourceCard, string destinationCard, float transferAmount)
        {
            var accuont = appDbContext.Transactions.FirstOrDefault
                (
                x=>x.SourceCardNumber==sourceCard && 
                x.DestinationCardNumber==destinationCard
                );
            if (accuont != null) 
            {
                if (transferAmount>0)
                {
                    if (accuont.Amount > transferAmount)
                    {

                    }
                }

            }
        }

        public List<Transaction> GetTransactions(string sourceCard)
        {
            var ac=appDbContext.Transactions.Where(x=>x.SourceCardNumber==sourceCard);
            if (ac != null) 
            {
                return ac.ToList();
            }
            return new List<Transaction>();
        }

    }
}
