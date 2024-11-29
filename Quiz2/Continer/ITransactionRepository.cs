using Quiz2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.Continer
{
    public interface ITransactionRepository
    {
        public List<Card> GetTransactions(string sourceCard);
    }
}
