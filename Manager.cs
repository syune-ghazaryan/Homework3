using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter2
{
    /// <summary>
    /// Define class which Manage the process of filtration
    /// </summary>
    class Manager
    {
        
        List<Student> filteredList;//Filtered list of students
        List<Filter> filters;
        Filter yearFilter = new Filter();//Filter which filters Students by Year
        Filter nameFilter = new Filter();//Filter which filters Students by Name
        Filter surnameFilter = new Filter();//Filter which filters Students by surname
        Filter phoneFilter = new Filter();//Filter which filters Students by Phone
        Filter languageFilter = new Filter();//Filter which filters Students by Languge amount 
        ListOfStudents student = new ListOfStudents("Students.xls");//List of students which is filtred 
        ListOfFilters f = new ListOfFilters("Filters.xls");//List of filter parameters

       
        public Manager()
        {
           
            FilterCreator filterCreator = new FilterCreator();
            yearFilter = filterCreator.YearFilter(f.YearLowerBound,f.YearUpperBound);//creating year filter and pass lower and upper bound
            nameFilter = filterCreator.NameFilter(f.NameCompare);
            surnameFilter = filterCreator.SurnameFilter(f.SurnameCompare);//creating surname filter and passing string to compare
            phoneFilter = filterCreator.PhoneFilter(f.PhoneCompare);
            languageFilter = filterCreator.LanguageFilter(f.LanguageLowerBound, f.LanguageUpperBound);
            filters = new List<Filter>{nameFilter, surnameFilter, phoneFilter, yearFilter, languageFilter};
           // filters = new Dictionary<string, Filter> { {f.NameCompare, nameFilter}, {f.SurnameCompare,surnameFilter},{f.PhoneCompare,phoneFilter},{f.LanguageLowerBound.ToString()+"-"+f.LanguageUpperBound.ToString(), languageFilter},{f.YearLowerBound.ToString()+"-"+ f.YearUpperBound.ToString(),yearFilter } };
            

        }
       /// <summary>
       /// Output filtered list
       /// </summary>
       public void PrintFilteredList()
        {
            int i = 1;
          foreach(Filter filter in filters)
          {
              Console.WriteLine("--------");
              Console.WriteLine("Filter " + i.ToString()+"\n");
              filteredList = student.Students.Where(filter.GetLambda()).ToList();
              foreach(Student item in filteredList)
              {
                  Console.WriteLine(item);
              }
              i++;
          }
        }
        
    }
}
