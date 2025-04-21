using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoptMe___GROUP5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                Form2 mainForm = new Form2();
                mainForm.Show();

            }
            else
            {
                MessageBox.Show("Invalid credentials!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
