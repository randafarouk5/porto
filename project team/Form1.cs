using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_team
{
    public partial class Form1 : Form
    {

        string reg_name = "hall mg";
        string reg_pass = "1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((unbox.Text == reg_name) && (passbox.Text == reg_pass))
            {
                Form2 f1= new Form2(reg_name);
                f1.Show();
                this.Hide();
            }
            else
            {

                string Message = "invalid username or password";
                MessageBox.Show(Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void closebt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
