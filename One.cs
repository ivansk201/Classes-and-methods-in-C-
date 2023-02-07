using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Work
{
    internal class One
    {
        public double w = 0;
        public double one()
        {   for (int i=1; i<=10;i++)
            {
                w = Math.Pow(i, 2);
                if (w<=25)
                MessageBox.Show(Convert.ToString(w), "Цикл", MessageBoxButtons.OK);
            }
            return w;
        }
        
    }
}
