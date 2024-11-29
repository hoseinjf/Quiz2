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
            throw new NotImplementedException();
        }

        public List<Card> GetTransactions(string sourceCard)
        {
            throw new NotImplementedException();
        }

    }
}
