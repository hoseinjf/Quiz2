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
    public class CardRepository : ICardRepository
    {
        private readonly AppDbContext appDbContext;
        public CardRepository()
        {
            appDbContext=new AppDbContext();
        }
        public void Transfer(string sourceCard, string destinationCard, float transferAmount)
        {
            throw new NotImplementedException();
        }
    }
}
