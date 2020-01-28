using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool flag;
            int i;
            int start;
            int end;
            string buff;

            int j;
            int square;
            int nextOddInteger;
            // ======gather inputs=====
            //Convert start from text to int
            flag = int.TryParse(txtStart.Text, out start);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                txtStart.Focus();
                return;
            }
            // Convert end from text to int
            flag = int.TryParse(txtEnd.Text, out end);
            if (flag == false)
            {
                MessageBox.Show("numeric data only", "Input Error");
                txtEnd.Focus();
                return;
            }
            if (start >= end)  //Reasonable values?
            {
                MessageBox.Show("Start greater than end.", "Input Error");
                txtStart.Focus();
                return;
            }
            //========Process and Display====
            //for (i = start; i <= end; i++)
            //{
            //    buff = string.Format("{0,5} {1,40}", i, i * i);
            //    lstOutput.Items.Add(buff);
            //}
            for (i = start; i <= end; i++)
            {
                nextOddInteger = 1;   // ste first odd integer
                square = 0;           // always start with square = 0
                for (j = 0; j < i; j++)  //nest j loop
                {
                    square += nextOddInteger;     //Sum the odd integer
                    nextOddInteger += 2;   //ser the next odd integer}
                    buff = string.Format("{0,5}{1,20}", i, square);
                    lstOutput.Items.Add(buff);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void BtnClear_Click_1(object sender, EventArgs e)
        {
            txtStart.Clear();
            txtEnd.Clear();
            lstOutput.Items.Clear();
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

  
