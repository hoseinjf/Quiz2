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
            var userAc = appDbContext.Cards.FirstOrDefault(x=>x.CardNumber==sourceCard);
            var destinationAc=appDbContext.Cards.FirstOrDefault(y=>y.CardNumber==destinationCard);
            if (userAc != null && destinationAc !=null) 
            {
                if (transferAmount>0)
                {
                    if (userAc.Balance > transferAmount)
                    {
                        userAc.Balance -= transferAmount;
                        destinationAc.Balance += transferAmount;
                        appDbContext.SaveChanges();
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
