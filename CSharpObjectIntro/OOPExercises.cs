using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpObjectIntro.Classes.Diary;
using CSharpObjectIntro.Classes.BankAccount;

namespace CSharpObjectIntro
{
    internal class OOPExercises
    {
        internal static void Run()
        {
            UseDiary();
        }

        internal static void UseDiary()
        {
            
            // Create a new diary 
            Diary diary = new Diary("Bob Smith");
            Console.WriteLine(diary.Name);
            DateOnly date = new DateOnly(2022, 10, 10); 
            // Add some events to your diary
            diary.AddEvent(date, 19, "football", "Gunsbury");
            diary.AddEvent(date, 9, "Cricket", "Kingston");

            // Now check how many events you have on a particular day
            int NumEvents = diary.CheckDiary(date);
            // Implement a new method in the Diary class to return the number of morning events on a particular day
            // Call this method
            Console.WriteLine(NumEvents);
            int MornEvents = diary.MorningEvents(date); 
            Console.WriteLine(MornEvents);

        }

        internal static void UseBankAccount()
        {
            // Implement your bank account class following the instructions in the BankAccount class



            // Write calling code from here
        }
    }
}

