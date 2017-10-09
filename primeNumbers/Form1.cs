using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool primeChecker(List<int> e, int num)
        {
            bool test = true;
            foreach(int i in e)
            {
                if (num % i == 0)
                {
                    test = false;
                    break;
                }
            }
            return test;
        }

        private void FuckDetHer_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int antal = Convert.ToInt32(entry.Text);
            int n = 2;
            int count = 5;
            List<int> primes = new List<int>();

            primes.Add(2);
            listBox1.Items.Add(2);
            primes.Add(3);
            listBox1.Items.Add(3);
            while (antal > n)
            {
                if(primeChecker(primes, count))
                {
                    primes.Add(count);
                    listBox1.Items.Add(count);
                    n++;
                }
                count += 2;
            }
            
            
        }
    }
}
