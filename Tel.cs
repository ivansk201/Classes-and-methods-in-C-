using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Work
{
    internal class Tel
    {
        public int day;
        public double t;
        private double price=10;
        public void prices(double tim)
        {
            if (day == 6 || day == 7)
                price = tim * (price * 0.9);
            else price = tim * price;
        }
        public bool Day(double day)
        {
            if (day < 0 || day > 7)
                return false;
            else return true;
        }
        public double money()
        {
            return price;
        }
    }
}
