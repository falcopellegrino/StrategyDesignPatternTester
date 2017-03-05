﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternTester.RealWorldCode
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.MergeSort(); // not-implemented
            Console.WriteLine("Mergesorted list ");
        }
    }
}
