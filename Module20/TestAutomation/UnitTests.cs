using System;
using DataDrivenFramework;
using NUnit.Framework;

namespace TestAutomation
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void SuiteSelectionTest()
        {
            Console.WriteLine(SelectionHelper.IsSuiteSelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\Suite.xlsx", "SuiteA"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\Suite.xlsx", "SuiteB"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\Suite.xlsx", "SuiteC"));
        }

        
        [Test]
        public void FunctionalitySelectionTest()
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine(SelectionHelper.IsFunctionalitySelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\SuiteA.xlsx", "Func1"));
            Console.WriteLine(SelectionHelper.IsFunctionalitySelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\SuiteA.xlsx", "Func2"));
            Console.WriteLine(SelectionHelper.IsFunctionalitySelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\SuiteA.xlsx", "Func3"));
            Console.WriteLine(SelectionHelper.IsFunctionalitySelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\SuiteA.xlsx", "Func4"));
        }
        
    }
}