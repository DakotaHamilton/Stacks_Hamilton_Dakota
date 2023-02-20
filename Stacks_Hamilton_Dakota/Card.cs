using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Hamilton_Dakota
{
    /// <summary>
    ///  Card Class For getting and setting both Defining Factors for each Card
    /// </summary>
    class Card
    {
        public string Number { get; }

        public string Suit { get; }

        public Card(string numParam, string suitParam)
        {
            Number = numParam;
            Suit = suitParam;
        }
    }
}
