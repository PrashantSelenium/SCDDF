using System;
using DataDrivenFramework;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestAutomation
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void SuiteSelectionTest()
        {
            Console.WriteLine(SelectionHelper.IsSuiteSelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\Suite.xlsx", "Suite Name"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\Suite.xlsx", "SuiteA"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\Suite.xlsx", "SuiteB"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\Suite.xlsx", "SuiteC"));
        }

        
        [Test]
        public void FunctionalitySelectionTest()
        {
            
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine(SelectionHelper.IsFunctionalitySelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\SuiteA.xlsx", "Functionality Name"));
            Console.WriteLine(SelectionHelper.IsFunctionalitySelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\SuiteA.xlsx", "Func1"));
            Console.WriteLine(SelectionHelper.IsFunctionalitySelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\SuiteA.xlsx", "Func2"));
            Console.WriteLine(SelectionHelper.IsFunctionalitySelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\SuiteA.xlsx", "Func3"));
            Console.WriteLine(SelectionHelper.IsFunctionalitySelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\SuiteA.xlsx", "Func4"));
            Console.WriteLine(SelectionHelper.IsFunctionalitySelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\SuiteA.xlsx", "Func5"));
            Console.WriteLine(SelectionHelper.IsFunctionalitySelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\SuiteA.xlsx", "Func6"));
            Console.WriteLine(SelectionHelper.IsFunctionalitySelected("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\SuiteA.xlsx", "Func7"));
            
        }

        [Test]
        public void TestDataReadingTest()
        {
            List<Dictionary<String,String>> tdList= SelectionHelper.GetTestData("H:\\Seleniumc#\\SCDDF\\Module20\\TestAutomation\\TestData\\SuiteA.xlsx", "Func2", "Func1");                   
            foreach (var dict in tdList)
            {
                Console.WriteLine(dict["RunMode"]);
            }
                           
        }
    }
}