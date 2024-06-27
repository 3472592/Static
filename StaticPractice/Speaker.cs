using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPractice
{
    class Speaker
    {
        public static int Multi(int x, int y)
        {
            int twoNums;

            twoNums = x * y;
            MessageBox.Show(x + " x " + y + "?");
            return twoNums;
        }

        public static int Divide(int x, int y)
        {

            if (x == 0 && y == 0)
            {
                MessageBox.Show("Can not divide by 0!");
                return 0;
            }
            else if (x >= 1 && y == 0) 
            {
                MessageBox.Show("Can not divide by 0!");
                return 0;
            }
            else if (x == 0 && y >= 0)
            {
                MessageBox.Show("Can not divide by 0!");
                return 0;
            }

            int twoNums;

            twoNums = x / y;
            MessageBox.Show(x + " / " + y + "?");
            return twoNums;
        }
        public static int Add(int x, int y)
        {
            int twoNums;

            twoNums = x + y;
            MessageBox.Show(x + " + " + y + "?");
            return twoNums;
        }

        public static int Sub(int x, int y)
        {
            int twoNums;

            twoNums = x - y;
            MessageBox.Show(x + " - " + y + "?");
            return twoNums;
        }
    }
}
