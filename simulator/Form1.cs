using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = (10);
            textBox2.MaxLength = (10);
            textBox3.MaxLength = (10);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (" ");
            label2.Text = (" ");
            label3.Text = (" ");

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button1.Visible = false;


            label1.Location = new Point(255, 107);
            label1.Size = new Size(150, 35);
            label2.Location = new Point(250, 150);
            label2.Size = new Size(125, 20);
            label3.Location = new Point(250, 200);




            label1.Text = "Имя: " + textBox1.Text;
            label2.Text = "Фамилия: " + textBox2.Text;
            label3.Text = "Пароль: " + textBox3.Text;


            if (textBox3.Text == "010203" && textBox1.Text == "кекич" && textBox2.Text == "119")
            {
                label4.Text = ("Вы успешно вошли в аккаунт");

                button2.Visible = true;
                button4.Visible = true;

            }

            if (textBox3.Text != "010203" && textBox1.Text != "кекич" && textBox2.Text != "119")
            {
                button3.Visible = true;
                label4.Text = "БЛИН. КУДА Я ЖМАЛ?";

            }

           if (textBox3.Text != "010203")
            {
                button3.Visible = true;
                label4.Text = "БЛИН. КУДА Я ЖМАЛ?";
                label5.Text = "вы ввели неправельный пароль: ";
            }

           if (textBox1.Text != "кекич")
            {
                button3.Visible = true;
                label4.Text = "БЛИН. КУДА Я ЖМАЛ?";
                label7.Text = "вы ввели неправельное имя: ";
            }
           if (textBox2.Text != "119")
            {
                button3.Visible = true;
                label4.Text = "БЛИН. КУДА Я ЖМАЛ?";
                label6.Text = "вы ввели неправельную фамилию: ";
            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    }

