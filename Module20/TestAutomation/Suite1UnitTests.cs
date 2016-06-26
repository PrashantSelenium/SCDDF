using System;
using DataDrivenFramework;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestAutomation
{
    [TestFixture]
    public class Suite1UnitTests
    {
        [Test]
        public void SuiteSelectionTest()
        {
            Console.WriteLine(SelectionHelper.IsSuiteSelected(ResourcsTestFilePaths.SuitesExcelFilePath, "Suite Name"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected(ResourcsTestFilePaths.SuitesExcelFilePath, "SuiteA"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected(ResourcsTestFilePaths.SuitesExcelFilePath, "SuiteB"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected(ResourcsTestFilePaths.SuitesExcelFilePath, "SuiteC"));
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