using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter2
{
    /// <summary>
    /// Define class which create filter
    /// </summary>
    class FilterCreator
    {

        public string FilterType { get; private set; }

        /// <summary>
        /// Function which create Year filter  with its lambda expression
        /// </summary>
        /// <param name="low"> lower bound</param>
        /// <param name="up">upper bound</param>
        /// <returns>Filter </returns>
        public Filter YearFilter(int low, int up)
        {
            this.FilterType = "Year Filter";
            Func<Student, bool> lambda= (s=>s.yearOfBirth>low && s.yearOfBirth <up);
            Filter filter = new Filter();
            filter.SetLambda(lambda);
            return filter;  
        }
        public Filter LanguageFilter(int low, int up)
        {
            this.FilterType = "Language Filter";
            
            Func<Student, bool> lambda= (s=>s.numberOfLanguage>low && s.numberOfLanguage <up);
            Filter filter = new Filter();
            filter.SetLambda(lambda);
            return filter;
        }
        public Filter NameFilter(string str)
        {
            this.FilterType = "Name Filter";
           
            Func<Student, bool> lambda = (s => s.Name.Contains(str));
            Filter filter = new Filter();
            filter.SetLambda(lambda);
            return filter;
        }
        public Filter SurnameFilter(string str)
        {
            this.FilterType = "Surname Filter";
          
            Func<Student, bool> lambda = (s => s.Surname.Contains(str));
            Filter filter = new Filter();
            filter.SetLambda(lambda);
            return filter;
        }
        public Filter PhoneFilter(string str)
        {
            this.FilterType = "Phone Filter";
           
            Func<Student, bool> lambda = (s => s.phoneNumber.ToString().Contains(str));
            Filter filter = new Filter();
            filter.SetLambda(lambda);
            return filter;
        }
    }
}
