using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structural = StrategyDesignPatternTester.SctructuralCode;
using Real = StrategyDesignPatternTester.RealWorldCode;
using My = StrategyDesignPatternTester.MyCode;

namespace StrategyDesignPatternTester
{
    // Definition
    // Define a family of algorithms, encapsulate each one, and make them interchangeable.
    // Strategy lets the algorithm vary independently from clients that use it. 

    // Participants
    // The classes and objects participating in this pattern are:
    //  - Strategy (SortStrategy)
    //       - declares an interface common to all supported algorithms.
    //       - Context uses this interface to call the algorithm defined by a ConcreteStrategy
    //  - ConcreteStrategy (QuickSort, ShellSort, MergeSort)
    //       - implements the algorithm using the Strategy interface
    //  - Context (SortedList)
    //       - is configured with a ConcreteStrategy object
    //       - maintains a reference to a Strategy object
    //       - may define an interface that lets Strategy access its data.

    /// <summary>
    /// MainApp startup class for
    /// Strategy Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            #region Structural code in C#
            // Structural code in C#
            // This structural code demonstrates the Strategy pattern which encapsulates functionality in the form of an object.
            // This allows clients to dynamically change algorithmic strategies.
            Structural.Context context;
            
            // Three contexts following different strategies
            context = new SctructuralCode.Context(new Structural.ConcreteStrategyA());
            context.ContextInterface();

            context = new SctructuralCode.Context(new Structural.ConcreteStrategyB());
            context.ContextInterface();

            context = new SctructuralCode.Context(new Structural.ConcreteStrategyC());
            context.ContextInterface();

            // Wait for user
            Console.ReadKey();
            #endregion

            #region Real-world code in C#
            // Real-world code in C#
            // This real-world code demonstrates the Strategy pattern which encapsulates sorting algorithms in the form of sorting objects.
            // This allows clients to dynamically change sorting strategies including Quicksort, Shellsort, and Mergesort.

            // Two contexts following different strategies
            Real.SortedList studentsRecord = new Real.SortedList();

            studentsRecord.Add("Samuel");
            studentsRecord.Add("Jimmy");
            studentsRecord.Add("Sandra");
            studentsRecord.Add("Vivek");
            studentsRecord.Add("Anna");

            studentsRecord.SetSortStrategy(new Real.QuickSort());
            studentsRecord.Sort();

            studentsRecord.SetSortStrategy(new Real.ShellSort());
            studentsRecord.Sort();

            studentsRecord.SetSortStrategy(new Real.MergeSort());
            studentsRecord.Sort();

            // Wait for user
            Console.ReadLine();
            #endregion

            #region MyCode
            My.GoogleMaps maps;

            maps = new My.GoogleMaps(new My.CreatoreDiPercorsoBreve());
            maps.CreaPercorso();

            maps = new My.GoogleMaps(new My.CreatoreDiPercorsoVeloce());
            maps.CreaPercorso();


            // Wait for user
            Console.ReadLine();
            #endregion
        }
    }
}
