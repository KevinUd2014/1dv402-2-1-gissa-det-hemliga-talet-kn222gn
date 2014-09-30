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
            if (_count >= MaxNumberOfGuesses)
            {
                throw new ApplicationException();
            }

        }
    }
}
