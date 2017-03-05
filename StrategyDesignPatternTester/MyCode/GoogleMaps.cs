using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    class GoogleMaps
    {
        private PercorsoStrategy _strategy;

        // Constructor
        public GoogleMaps(PercorsoStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void CreaPercorso()
        {
            _strategy.CreaPercorso();
        }
    }
}
