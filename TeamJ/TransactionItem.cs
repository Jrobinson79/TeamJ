using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using DomainClasses;

namespace TeamJ
{
    public class TransactionItem
    {
        private Sale sale;
        private Person person;
        private String transactionType;

        public TransactionItem(Person person, Sale sale, String transactionType)
        {
            this.sale = sale;
            this.person = person;
            this.transactionType = transactionType;
        }

        public Sale getSale()
        {
            return sale;
        }

        public Person getPerson()
        {
            return person;
        }

        public String getTransactionType()
        {
            return transactionType;
        }

        public override string ToString()
        {
            return person.FirstName + " " + person.LastName + " - " + 
                   sale.Date.ToShortDateString() +" - " + 
                   this.transactionType;
        }
    }
}
