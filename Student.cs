using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Work
{
    class Student
    {
       public string name;
        public int rost;
       private double ves=50;
        public void Eat(double ed)
        {
            ves+=(ed*1000-1600)/1000;
        }
        public double GetEat()
        {
            return ves;
        }
        

    }
}
