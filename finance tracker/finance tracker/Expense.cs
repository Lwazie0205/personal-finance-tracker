using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finance_tracker
{
    public class Expense
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public Expense(string description, decimal amount, DateTime date)
        {
            Description = description;
            Amount = amount;
            Date = date;

        }

    }
 }
   
       

 