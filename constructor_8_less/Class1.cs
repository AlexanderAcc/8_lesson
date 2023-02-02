using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_8_less
{
    internal class Class1
    {
        private string second_string;
        private int first_int;

        public Class1(string s)
        {
            second_string = s;
            System.Windows.MessageBox.Show(Convert.ToString(first_int) + " " + second_string);
        }
        public Class1(string s, int a)
        {
            second_string = s;
            first_int = a;
            System.Windows.MessageBox.Show(Convert.ToString(first_int) + " " + second_string);
        }
    }
}
