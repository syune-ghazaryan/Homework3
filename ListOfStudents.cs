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
    /// Class which describe how to get list of students from .xls file and write data to list
    /// </summary>
    public class ListOfStudents
    {
        
          /// <summary>
          /// list which store students
          /// </summary>
            List<Student> students = new List<Student>();

      
            internal List<Student> Students
            {
                get { return students; }
                set { students = value; }
            }

           /// <summary>
           /// Constructor 
           /// </summary>
           /// <param name="fileStudent"> name of file, which contains info about students</param>
            public ListOfStudents(string fileStudent)
            {
                List<string> names = new List<string>();
                List<string> surnames = new List<string>();
                List<int> years = new List<int>();
                List<int> languageAmounts = new List<int>();
                List<int> phoneNumbers = new List<int>();
                GetFile getStudentFile = new GetFile(fileStudent);
                Excel.Range xlRange = getStudentFile.getXlrange();
                int rowsCount = xlRange.Rows.Count;
                for (int i = 2; i <= rowsCount; i++)
                {
                    string name = xlRange.Cells[i, 1].Value.ToString();
                    string surname = xlRange.Cells[i, 2].Value.ToString();
                    int year = Parsed(xlRange.Cells[i, 3].Value.ToString());
                    int languageAmount = Parsed(xlRange.Cells[i, 4].Value.ToString());
                    int phoneNumber = Parsed(xlRange.Cells[i, 5].Value.ToString());
                    names.Add(name);
                    surnames.Add(surname);
                    years.Add(year);
                    languageAmounts.Add(languageAmount);
                    phoneNumbers.Add(phoneNumber);
                    Student student = new Student(name, surname, year, languageAmount, phoneNumber);
                    this.Students.Add(student);
                }
                
            }
           
       /// <summary>
       /// function return parsed int if the result of TryParse is true
       /// </summary>
       /// <param name="number">number which should be parsed </param>
       /// <returns></returns>
       public static int Parsed(string number)
        {
            int result = 0;
            Int32.TryParse(number, out result);
            return result;
        }
    }
}
