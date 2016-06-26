using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenFramework
{
    public class SelectionHelper
    {
        public static bool IsSuiteSelected(String suiteFilePath, String suiteName)
        {
            ExcelReaderFile exl = new ExcelReaderFile(suiteFilePath);
            int suiteRowNumber = exl.getRowNumber("SuiteList", 0,suiteName);
            //Console.WriteLine("suiteRowNumber --> " + suiteRowNumber);
            String suiteRunMode = exl.getCellData("SuiteList",1,suiteRowNumber);
            //Console.WriteLine("suiteRunMode --> " + suiteRunMode);
            if (suiteRunMode.Equals("Y",StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }


        public static bool IsFunctionalitySelected(String suiteFilePath, String funcName)
        {
            ExcelReaderFile exl = new ExcelReaderFile(suiteFilePath);
            int suiteRowNumber = exl.getRowNumber("Functionalties", 0, funcName);
            String funcRunMode = exl.getCellData("Functionalties", 1, suiteRowNumber);
            if (funcRunMode.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static List<Dictionary<String, String>> GetTestData(String suiteFilePath, String funcName,String testCaseName)
        {
            List<Dictionary<String,String>> listOfData = new List<Dictionary<String, String>>();
            
            ExcelReaderFile exl = new ExcelReaderFile(suiteFilePath);
            int testCaseRowNumber = exl.getRowNumber(funcName, 0,testCaseName);
            int testHeaderRowNumber = testCaseRowNumber + 1;
            int testDataStartRowNumber = testHeaderRowNumber + 1;
            int testDataEndRowNumber = testHeaderRowNumber;
            int counter = testDataStartRowNumber;

            while (!exl.getCellData(funcName, 0, counter).Equals(""))
            {
                
                counter++;
                testDataEndRowNumber++;
                Console.WriteLine("Run Mode --> " + exl.getCellData(funcName, 0, testDataEndRowNumber));
            }

            Console.WriteLine("testCaseRowNumber --> " + testCaseRowNumber);
            Console.WriteLine("testHeaderRowNumber --> " + testHeaderRowNumber);
            Console.WriteLine("testDataStartRowNumber --> " + testDataStartRowNumber);
            Console.WriteLine("testDataEndRowNumber --> " + testDataEndRowNumber);
            
            for (int i= testDataStartRowNumber; i<=testDataEndRowNumber; i++)
            {
                Console.WriteLine("***********************************************************************");
                Dictionary<String, String> data = new Dictionary<String, String>();
                int colID = 0;
                while (!exl.getCellData(funcName, colID, testHeaderRowNumber).Equals(""))
                {
                    data.Add(exl.getCellData(funcName, colID, testHeaderRowNumber), exl.getCellData(funcName, colID, i));
                    Console.WriteLine("Cell Data --> "+ exl.getCellData(funcName, colID, i));
                    colID++;
                    
                }

                Console.WriteLine("***********************************************************************");

                listOfData.Add(data);
            }
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            return listOfData;
        }


    }
   




}
