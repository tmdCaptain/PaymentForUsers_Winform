using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degin_Employee_Coffee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quatity q = new quatity();
            q.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }


        

       

        
        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 f3 = new Form2();
            f3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
                Form6 f6 = new Form6();
                f6.Show();
                this.Hide();
            

        }
    }
}
