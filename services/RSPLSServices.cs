using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPSLS_Game.services
{
    public class RSPLSServices
    {
        public string RandomComputerChoice()
        {

            {
                Random rng = new Random();
                int possibleResponse = rng.Next(1, 6);


                switch (possibleResponse)
                {
                    case 1:
                        return "Rock";
                    case 2:
                        return "Paper";
                    case 3:
                        return "Scissors";
                    case 4:
                        return "Lizard";
                    case 5:
                        return "Spock";
                    default: 
                        return "ERROR ERROR ERROR!!!";
                }
            }
        }
    }
}