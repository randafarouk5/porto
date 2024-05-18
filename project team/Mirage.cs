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
    public partial class Mirage : Form
    {
        public Mirage()
        {
            InitializeComponent();
        }

        private void Mirage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            client_form client_Form = new client_form();
            client_Form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                booking b = new booking();
            b.Show();
            this.Hide();
        }
    }
}
