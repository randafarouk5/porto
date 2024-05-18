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
    public partial class Form2 : Form
    {
        string un;

        public Form2(string un)
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            client_form client = new client_form();
            client.Show();
            this.Hide();        }

        private void button2_Click(object sender, EventArgs e)
        {
            information f= new information();
            f.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
