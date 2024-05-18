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
    public partial class client_form : Form
    {
        public client_form()
        {
            InitializeComponent();
        }

        private void client_form_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Tulip tulip = new Tulip();
            tulip.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Venicia venicia = new Venicia();
            venicia.Show(); 
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Mirage mirage = new Mirage();   
            mirage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Form2 f=new Form2(string.Empty);
            f.Show();
            this.Hide();
        }
    }
}
