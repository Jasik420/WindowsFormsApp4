using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace zgadywanieliczb
{
    public partial class Form1 : Form
    {
        int nrPr = 1;
        int los = 0;




        public Form1()
        {
            InitializeComponent();
        }



        public void button1_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            if (radioButton1.Checked)



                los = rand.Next(0, 1000);
            else if (radioButton2.Checked)
                los = rand.Next(0, 100);
            else
                los = rand.Next(0, 10);

            textBox1.Text = "1";
            textBox2.Clear();
            button1.Enabled = false;
            panel2.BackColor = Control.DefaultBackColor;



        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {



        }



        public void button2_Click(object sender, EventArgs e)
        {
            int amogus = -1;
            try
            {

                amogus = Convert.ToInt32(textBox2.Text);
            }

            catch (Exception ex)
            {

                MessageBox.Show("Bruh");
                textBox2.Clear();
                return;
            }



            if (checkBox1.Checked)
            {



                if (amogus > los)
                    label4.Text = ("wpisałeś większą liczbę");
                else if (amogus < los)
                    label4.Text = ("wpisałeś mniejszą liczbę");



                else if (amogus == los)
                {



                    label5.Text = ("Zgadłeś!");



                    panel2.BackColor = Color.Red;



                    label1.BackColor = Color.Red;



                    label5.Font = new Font("Arial", 10, FontStyle.Bold);



                    label4.Font = new Font("Arial", 30);



                    label4.Text = ("Pro");



                }



            }



            nrPr++;
            textBox1.Text = Convert.ToString(nrPr);



            if (nrPr > 10)
            {



                label7.Font = new Font("Arial", 30);



                label7.Text = "Noob";
            }
        }







        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void Form1_Load(object sender, EventArgs e)
        {



        }



        private void label5_Click(object sender, EventArgs e)
        {



        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {



        }



        private void label1_Click(object sender, EventArgs e)
        {



        }



        private void label4_Click(object sender, EventArgs e)
        {



        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }



        private void label7_Click(object sender, EventArgs e)
        {



        }
    }
}