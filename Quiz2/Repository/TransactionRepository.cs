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
        public bool Transfer(int sourceCard, int destinationCard, float transferAmount)
        {
            
            var userAc = appDbContext.Cards.FirstOrDefault(x=>x.Id==sourceCard);
            var destinationAc=appDbContext.Cards.FirstOrDefault(y=>y.Id==destinationCard);
            if (userAc != null && destinationAc !=null) 
            {
                if (transferAmount>0)
                {
                    if (userAc.Balance > transferAmount)
                    {
                        if (userAc.CardNumber != destinationAc.CardNumber)
                        {
                            userAc.Balance -= transferAmount;
                            destinationAc.Balance += transferAmount;
                            Transaction transaction = new Transaction()
                            {
                                SourceCardId = sourceCard,
                                SourceCard = userAc,
                                DestinationCard = destinationAc,
                                DestinationCardId = destinationCard,
                                Amount = transferAmount,
                                isSuccessful = true,
                                TransactionDate = DateTime.UtcNow
                            };
                            appDbContext.Transactions.Add(transaction);
                            appDbContext.SaveChanges();
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public List<Transaction> GetTransactions(int Id)
        {
            //var userAc = appDbContext.Cards.FirstOrDefault(x => x.Id == sourceCard);
            var ac=appDbContext.Transactions.Where(x=>x.SourceCardId==Id
            || x.DestinationCardId==Id).ToList();
            if (ac != null) 
            {
                return ac;
            }
            return new List<Transaction>();
        }

    }
}
