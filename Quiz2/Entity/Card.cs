﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.Entity
{
    public class Card
    {
        public string CardNumber { get; set; }
        public string HolderName { get; set; }
        public float Balance { get; set; }
        public bool IsActive { get; set; }
        public string Password { get; set; }
    }
}
