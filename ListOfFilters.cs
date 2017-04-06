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
    /// Define class which create list of Filters getting data form .xls file
    /// </summary>
    class ListOfFilters
    {
#region Properties
        public string NameCompare{  get;private set ;}
        public string SurnameCompare { get; private set; }
        public string   PhoneCompare{get;private set;}
        public int YearUpperBound{get; private set;}
        public int YearLowerBound{get;private set;}
        public int LanguageUpperBound { get; private set; }
        public int LanguageLowerBound { get; private set; }

#endregion    
 
        /// <summary>
        /// Cunstructor
        /// </summary>
        /// <param name="fileFilter">filter file name</param>
        public ListOfFilters(string fileFilter)
        {

            GetFile getFilterFile = new GetFile(fileFilter);
            Excel.Range xlRange1 = getFilterFile.getXlrange();

            this.NameCompare = xlRange1.Cells[1, 1].Value.ToString();
            this.SurnameCompare = xlRange1.Cells[2, 1].Value.ToString();
            this.PhoneCompare= xlRange1.Cells[5, 1].Value.ToString();
            this.YearLowerBound =ListOfStudents.Parsed(xlRange1.Cells[3, 1].Value.ToString());
            this.YearUpperBound = ListOfStudents.Parsed(xlRange1.Cells[3, 2].Value.ToString());
            this.LanguageLowerBound = ListOfStudents.Parsed(xlRange1.Cells[4, 1].Value.ToString());
            this.LanguageUpperBound = ListOfStudents.Parsed(xlRange1.Cells[4, 2].Value.ToString());

        }

    }
}
