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
    public partial class information : Form
    {
        public information()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("user_file.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] or = line.Split(',');
                var lv = new ListViewItem(or);
                listView1.Items.Add(lv);
            }
            sr.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 f=new Form2(string.Empty);
            f.Show();
            this.Hide();
        }

        private void information_Load(object sender, EventArgs e)
        {

        }
    }
}
