using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternTester.MyCode
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class CreatoreDiPercorsoBreve : PercorsoStrategy
    {
        public override void CreaPercorso()
        {
            Console.WriteLine("Creazione del percorso più breve...");
        }
    }
}
