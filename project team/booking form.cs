using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_team
{
    public partial class booking_form : Form
    {
        public static string fileLocation =( Environment.SpecialFolder.Desktop)+@"\bookingfile";
        
        public booking_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((clienttb.Text != null) && (phonetb.Text != null) && (datetb.Text != null)
               && (emailtb.Text != null) && (clientidtb.Text != null) && (hallidtb.Text != null))
            {

                
                StreamWriter writer = new StreamWriter(fileLocation, append: true);
                string new_client = clienttb.Text + "," + phonetb.Text + "," + datetb.Text +
                    "," + emailtb.Text + "," + clientidtb.Text + "," + hallidtb.Text;
                writer.WriteLine(new_client);
                writer.Close();
                MessageBox.Show("file saved");
            }
            else
            {
                MessageBox.Show("error data");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
