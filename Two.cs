using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Work
{
    internal class Two
    {
        public void Tw()
        {
                One one = new One();
                if (one.one() > 25)
                    MessageBox.Show("Квадрат числа больше 25!", "Цикл", MessageBoxButtons.OK);
                else MessageBox.Show(Convert.ToString(one.one()), "Цикл", MessageBoxButtons.OK);
        }
    }
}
