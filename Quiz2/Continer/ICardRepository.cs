﻿using Quiz2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.Continer
{
    public interface ICardRepository
    {
        public void Transfer(string sourceCard,string destinationCard,float transferAmount);
    }
}