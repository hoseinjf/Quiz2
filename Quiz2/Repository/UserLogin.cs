﻿using Quiz2.Context;
using Quiz2.Continer;
using Quiz2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.Repository
{
    public class UserLogin : IUserLogin
    {
        private readonly AppDbContext _appDbContext;
        public UserLogin()
        {
            _appDbContext = new AppDbContext();
        }
        public Card Login(string cardNumber, string password)
        {
            var ac = _appDbContext.Cards.FirstOrDefault
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
