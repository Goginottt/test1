using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp4
{
    internal class Hachapuri
    {
        public void HD(double c1, double c2)
        {
            double c3;
            c3 = c1 * c2;
            MessageBox.Show("У вас получилось " + $"{c3}");
        }
    }
}
