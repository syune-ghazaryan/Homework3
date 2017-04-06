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
    /// <summary>
    /// Define class which get file
    /// </summary>
    public class GetFile
    { 
        public string Filename { get; private set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filename">name of file </param>
        public GetFile(string filename)
        {
            this.Filename = filename;
        }
        /// <summary>
        /// Function which get Exel Range
        /// </summary>
        /// <returns>range </returns>
        public Excel.Range getXlrange()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), this.Filename);
            Excel.Application xlApp = new Excel.Application();
            string workbookPath = Application.StartupPath+@"\" + this.Filename;
            //~~> Start Excel and open the workbook.
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(workbookPath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            return xlRange;
        }
    }
}
