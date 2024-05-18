using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_team
{
    public partial class booking : Form
    {
        public booking()
        {
            InitializeComponent();
        }

        private void booking_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2(string.Empty);
            f.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("user_file.txt", append: true);
            sw.WriteLine(clientbt.Text + "," + phonebt.Text + "," + comboBox1.SelectedItem   + "," +
             emailbt.Text + "," + clientidbt.Text + "," + hallidbt.Text+","+ dateTimePicker1.Text);

            sw.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                sodaprice.Enabled = true;
                sodaqn.Enabled = true;
            }
            else
            {
                sodaprice.Enabled = false;
                sodaqn.Enabled = false;
                sodaprice.Text = "";
                sodaqn.Text = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                waterprice.Enabled = true;
                waterqn.Enabled = true;
            }
            else
            {
                waterprice.Enabled = false;
                waterqn.Enabled = false;
                waterprice.Text = "";
                waterqn.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        { 
            if (checkBox3.Checked == true)
            {
                juiceprice.Enabled = true;
                juiceqn.Enabled = true;
            }
            else
            {
                juiceprice.Enabled = false;
                juiceqn.Enabled = false;
                juiceprice.Text = "";
                juiceqn.Text = "";
            }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                chekprice.Enabled = true;
                chekqn.Enabled = true;
            }
            else
            {
                chekprice.Enabled = false;
                chekqn.Enabled = false;
                chekprice.Text = "";
                chekqn.Text = "";
            }
        }

        private void chekbox5_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox5.Checked == true)
            {
                pirprice.Enabled = true;
                pirqn.Enabled = true;
            }
            else
            {
                pirprice.Enabled = false;
                pirqn.Enabled = false;
                pirprice.Text = "";
                pirqn.Text = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                suprice.Enabled = true;
                su3qn.Enabled = true;
            }
            else
            {
                suprice.Enabled = false;
                su3qn.Enabled = false;
                suprice.Text = "";
                su3qn.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int soda = 0, water = 0, juice = 0;
            if (checkBox1.Checked == true)
            {
                if (sodaprice.Text == null && sodaqn.Text == null)
                {

                    MessageBox.Show("Enter soda quantity");
                }
                else
                {
                    soda = Convert.ToInt32(sodaprice.Text) * Convert.ToInt32(sodaqn.Text);
                }
            }
            if (checkBox2.Checked == true)
            {
                if (waterprice.Text == null && waterqn.Text == null)
                {
                    MessageBox.Show("Enter water quantity");
                }
                else
                {
                    water = Convert.ToInt32(waterprice.Text) * Convert.ToInt32(waterqn.Text);
                }
            }
            if (checkBox3.Checked == true)
            {
                if (juiceprice.Text == null && juiceqn.Text == null)
                {

                    MessageBox.Show("Enter juice quantity");
                }
                else
                {

                    juice = Convert.ToInt32(juiceprice.Text) * Convert.ToInt32(juiceqn.Text);

                }
            }
            int drink_cost = soda + water + juice;
            button3.Text = "" + drink_cost;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int chek = 0, beef = 0, soucoge = 0;
            if (checkBox6.Checked == true)
            {
                if (chekprice.Text == null && chekqn.Text == null)
                {

                    MessageBox.Show("Enter cheken quantity");
                }
                else
                {
                    chek = Convert.ToInt32(chekprice.Text) * Convert.ToInt32(chekqn.Text);
                }
            }
            if (chekbox5.Checked == true)
            {
                if (pirprice.Text == null && pirqn.Text == null)
                {
                    MessageBox.Show("Enter beef quantity");
                }
                else
                {
                    beef = Convert.ToInt32(pirprice.Text) * Convert.ToInt32(pirqn.Text);
                }
            }
            if (checkBox4.Checked == true)
            {
                if (suprice.Text == null && su3qn.Text == null)
                {

                    MessageBox.Show("Enter soucoge quantity");
                }
                else
                {

                    soucoge = Convert.ToInt32(suprice.Text) * Convert.ToInt32(su3qn.Text);

                }
            }
            int food_cost = chek+ beef + soucoge;
            button4.Text = "" + food_cost;
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total_price = double.Parse(totalbt.Text);
            string client = clientbt.Text;
            double price = 0;
            string hall = hallidbt.Text;
            string job = comboBox1.SelectedItem.ToString();
            DateTime date = dateTimePicker1.Value;
            try
            {
                double drinkcost = double.Parse(button3.Text);
                double foodcost = double.Parse(button4.Text);
                price = (drinkcost + foodcost);
                if (job == "programmer")
                {


                    double discountrate = .30;
                    double discountamount = total_price * discountrate;
                    total_price -= discountamount;
                    MessageBox.Show("Thank you,  " + client + "| your booking details:\n " +
                        "price: " + total_price.ToString() + "\n " +
                        "Hall ID: " + hall + "\n " +
                        "Job: " + job + "\n " +
                        "date: " + date.ToString() + "\n ",
                        "Receipt ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (job == "Accountant")
                {


                    double discountrate = .20;
                    double discountamount = total_price* discountrate;
                    total_price -= discountamount;
                    MessageBox.Show("Thank you,  " + client + "| your booking details:\n " +
                        "price: " + total_price.ToString() + "\n " +
                        "Hall ID: " + hall + "\n " +
                        "Job: " + job + "\n " +
                       "date: " + date.ToString() + "\n ",
                       "Receipt ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (job == "lawyer")
                {


                    double discountrate = .07;
                    double discountamount = total_price * discountrate;
                    total_price -= discountamount;
                    MessageBox.Show("Thank you,  " + client + "| your booking details:\n " +
                        "price: " + total_price.ToString() + "\n " +
                        "Hall ID: " + hall + "\n " +
                        "Job: " + job + "\n " +
                       "date: " + date.ToString() + "\n ",
                       "Receipt ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (job == "Doctor")
                {
                    double discountrate = .10;
                    double discountamount = total_price * discountrate;
                    total_price -= discountamount;
                    MessageBox.Show("Thank you,  " + client + "| your booking details:\n " +
                        "price: " + total_price.ToString() + "\n " +
                        "Hall ID: " + hall + "\n " +
                        "Job: " + job + "\n " +
                       "date: " + date.ToString() + "\n ",
                       "Receipt ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (job == "others") ;
                {
                    MessageBox.Show("Thank you,  " + client + "| your booking details:\n " +
                       "price: " + total_price.ToString() + "\n " +
                       "Hall ID: " + hall + "\n " +
                       "Job: " + job + "\n " +
                      "date: " + date.ToString() + "\n ",


                      "Receipt ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }




        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void pricebt_TextChanged(object sender, EventArgs e)
        {
             int p1=Convert.ToInt32(button4.Text);
            int p2=Convert.ToInt32(button3.Text);
            int p3 = p1 + p2;
            pricebt.Text = "" + p3;
        }

        private void totalbt_TextChanged(object sender, EventArgs e)
        {
            int p4=Convert.ToInt32(pricebt.Text);

            int p5 = Convert.ToInt32(hallbt.Text);
             int P6=p4 + p5;
            totalbt.Text = "" + P6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f=new Form2(string.Empty);
            f.Show();
            this.Hide();
        }
    }
    
}
