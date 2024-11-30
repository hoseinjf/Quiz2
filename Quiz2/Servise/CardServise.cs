using Quiz2.Entity;
using Quiz2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.Servise
{
    public class CardServise
    {
        private readonly CardRepository cardRepository;
        public CardServise()
        {
            cardRepository = new CardRepository();
        }
        public Card Get(string code)
        {
            return cardRepository.GetCardByCardNumber(code);
        }
    }
}
