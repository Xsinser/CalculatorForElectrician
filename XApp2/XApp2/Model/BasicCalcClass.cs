using System;
using System.Collections.Generic;
using System.Text;

namespace XApp2.Model
{
    class BasicCalcClass
    {
        protected string result;
        public string getResult { get { return result; } }
        public int ToInt() {
            return Convert.ToInt32(result); 
        } 


    }
}
