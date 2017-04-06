using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Filter2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Manager manager = new Manager();
            manager.PrintFilteredList();
        }



     
    }
}
