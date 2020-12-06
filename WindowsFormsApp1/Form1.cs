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
        private static int i, j;
        private void button1_Click(object sender, EventArgs e) 
        {
            double bill, tip, people,t1, t2;
            char c = '%';
            txttip.Text = txttip.Text.Replace(c.ToString(), String.Empty);
            bill = Convert.ToDouble(txtbill.Text);
            tip = Convert.ToDouble(txttip.Text);
            people = Convert.ToDouble(person.Text);
            if (tip < 0 || people <= 0 || bill <= 0)
            {
                string message = "Please enter a Valid Input";
                string title = "Invalid Input!";
                MessageBox.Show(message, title);
                string msg = "Do you want to abort this operation?";
                string tt = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                DialogResult result = MessageBox.Show(msg, tt, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Abort)
                {
                    this.Close();
                }
                else if (result == DialogResult.Retry)
                {
                    Form1 NewForm = new Form1();
                    NewForm.Show();
                    this.Dispose(false);
                }
            }
            t1 =  (bill/people) * tip/100;
            t2 = (bill / people) + t1;
            t1=Math.Round(t1, 2);
            t2=Math.Round(t2, 2);
            txttip.Text = tip.ToString() + "%";
            txtt1.Text = "$" + t1.ToString();
            txtt2.Text = "$" +t2.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
     
        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tip_TextChanged(object sender, EventArgs e)
        {

        }

        private void t2_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            j++;
            person.Text = j.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            i--;
            txttip.Text = i.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            i++;
            txttip.Text = i.ToString();
        }

        private void txttip_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            j--;
            person.Text = j.ToString();
        }
    }
}
