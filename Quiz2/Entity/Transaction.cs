using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.Entity
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        [MinLength(16)]
        [MaxLength(16)]
        public string SourceCardNumber { get; set; }
        [MinLength(16)]
        [MaxLength(16)]
        public string DestinationCardNumber { get; set; }
        public float Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public bool isSuccessful { get; set; }
    }
}
