using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
     public class SecretNumber
    {
        public const int MaxNumberOfGuesses = 7;  //Max antalet gissningar är lika med 7
        private int _count; //ska ha en _count 
        private int _number; // och en _number
        public const int minValue = 1; //och det minsta värdet ska vara 1
        public const int maxValue = 100; // och det högsta ska vara 100

        public SecretNumber() //anropar konstruktorn secretnumber och initierar det hemliga talet
        {
            Initialize();
        }

        public void Initialize() // gör initialiseringen till ett heltal och det får ett värde
        {
            Random Random = new Random(); // detta ska även vara helt slumpmässigt vilket random gör!
            _number = Random.Next(minValue, maxValue + 1); //tal man har att välja mellan 1 - 101
            _count = 0; //antalet gissningar kvar!
            //sätt en _number = 10; här så kan man lätt kolla så att alla if-satser ligger i rätt ordning!
        }


        public bool MakeGuess(int value)
        {
            if (_count >= MaxNumberOfGuesses)  //om detta händer så ska programmet kasta ett undantag som heter applicationexeption
            {
                throw new ApplicationException();
            }

            if (value < 1 || value > 100) // om talet är mindre än ett och eller större än 100 så läggs undantaget till!
            {
                Console.WriteLine("sorry your entry is out of the ratio of 1 and 100!");
                throw new ArgumentOutOfRangeException();
            }

            _count++; //ökar count med ett hela tiden!

            if (_number == value) //om numret personen skrivet in är rätt så skrivs detta ut!
            {
                Console.WriteLine("You're one lucky person, the number {0} is CORRECT!", _number);
                return true; //returnerar och visar programmet att detta är rätt och då kör det inte vidare!
            }

            if (_count == MaxNumberOfGuesses)// om du slösar alla dina gissningar så skickas detta!
            {
                Console.WriteLine();
                Console.WriteLine("sorry you've guessed {0} times and the correct answer was {1}", _count, _number);
                return false; // visar att detta är fel och avslutar programmet!
            }

            if (_number < value)
            {
                Console.WriteLine("You guessed {0} and it's to high, please make another guess! {1} guesses left", value, (MaxNumberOfGuesses - _count));

            }
            if (_number > value)
            {
                Console.WriteLine("You guessed {0} and it's to low, please make another guess! {1} guesses left", value, (MaxNumberOfGuesses - _count));

            }
            return false; // skickar att detta är fel när beroende på vilket tal man gissar på!

        }
    }
}
