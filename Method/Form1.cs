using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int iResult;
            //iResult = Convert.ToInt32(tboxNum1.Text) + Convert.ToInt32(tboxNum2.Text);
            int iA = Convert.ToInt32(tboxNum1.Text);
            int iB = Convert.ToInt32(tboxNum2.Text);

            tboxResult.Text = fPlus(iA, iB).ToString();
        }

        private int fPlus(int iA, int iB)
        {
            return iA + iB;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int iResult;
            iResult = Convert.ToInt32(tboxNum1.Text) - Convert.ToInt32(tboxNum2.Text);
            tboxResult.Text = Convert.ToString(iResult);
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            int iResult;
            iResult = Convert.ToInt32(tboxNum1.Text) * Convert.ToInt32(tboxNum2.Text);
            tboxResult.Text = Convert.ToString(iResult);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            int iResult;
            iResult = Convert.ToInt32(tboxNum1.Text) / Convert.ToInt32(tboxNum2.Text);
            tboxResult.Text = Convert.ToString(iResult);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tboxResult.Text = "";
            tboxNum1.Text = "";
            tboxNum2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
