using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter2
{ 
    /// <summary>
    /// Define class which describe filter
    /// </summary>
    class Filter
    {
        /// <summary>
        /// lambda expression
        /// </summary>
        Func<Student, bool> lambda;

         /// <summary>
         /// set lambda for filter
         /// </summary>
         /// <param name="lambdaL"></param>
        public void SetLambda(Func<Student, bool> lambdaL)
        {
            this.lambda = lambdaL;
        }
        /// <summary>
        /// get lambda for filter 
        /// </summary>
        /// <returns></returns>
        public Func<Student, bool> GetLambda()
        {
            return this.lambda;
        }
    }
}
