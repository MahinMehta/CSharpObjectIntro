using CSharpObjectIntro.Classes.Diary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjectIntro.Classes.BankAccount
{
    public class Transaction
    {
        public Transaction(DateOnly date, int hours, int minutes, string description, string location, int amount = 0, int duration = 60)
        {
            Date = date;
            Hours = hours;
            Minutes = minutes;  
            Description = description;  
            Location = location;
            Amount = amount;
            Duration = duration;    
            

        }
        public DateOnly Date { get; private set; }
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public string Description { get; private set; }
        public string Location { get; private set; }

        public int Amount { get; private set; }

        public int Duration { get; private set; }

    }
}
