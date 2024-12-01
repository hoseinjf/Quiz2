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
            appDbContext = new AppDbContext();
        }

        public bool ChengPassword(string username, string oldPassword, string newPassword)
        {
            var card = appDbContext.Cards
                .FirstOrDefault(x => x.Password == oldPassword
                && x.User.Username == username);
            if (card != null)
            {
                card.Password = newPassword;
                //appDbContext.Cards.Update(oldPass);
                appDbContext.Cards.Add(card);
                appDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public Card GetCardByCardNumber(string cardNumber)
        {
            var card = appDbContext.Cards.FirstOrDefault(x => x.CardNumber == cardNumber);
            return card;
        }

        public float SetTax(float Amount)
        {
            float tax = 0f;
            if (Amount != 0f)
            {
                if (Amount > 1000)
                {
                    tax = (Amount *1.5f)/100;
                    return Amount -= tax;
                }
                else if (Amount <= 1000) 
                {
                    tax = (Amount * 0.5f) / 100;
                    return Amount -= tax;
                }
            }
            return 0f;
        }

        public float ShowCardBalans(string cardNumber)
        {
            var card = appDbContext.Cards.FirstOrDefault(x => x.CardNumber == cardNumber);
            if (card != null)
            {
                return card.Balance;
            }
            return 0f;
        }
        public Card Login(string cardNumber, string password)
        {
            var ac = appDbContext.Cards.FirstOrDefault
                (x => x.CardNumber == cardNumber
                && x.Password == password);
            if (ac != null)
            {
                return ac;
            }
            return null;
        }

    }
}
