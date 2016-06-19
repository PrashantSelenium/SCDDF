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
    }
}
