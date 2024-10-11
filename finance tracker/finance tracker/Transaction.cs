using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finance_tracker
{
    public class Transaction
    {
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }

        // Parameterless constructor
        public Transaction() { }
    }
}
        
           
    


