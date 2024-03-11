using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prohjekt_lab_2
{
    public partial class Komputer : Form
    {
        public Form1 form1;
        public Komputer(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Jeśli tak, ustaw tekst etykiety na odpowiednią wartość
                textBox1.Text = "500";
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            

                form1.SetTextBoxTextFF1(textBox1.Text, textBox1.Text);


            
           
            this.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
        
            this.Close();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cenaDysku = textBox1.Text;

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            string cenaProcesora = textBox2.Text;
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wybranaOpcja = comboBox1.SelectedItem.ToString();
           if( wybranaOpcja == "Procesor 1")
            {
                textBox2.Text = "300";
            }
            if (wybranaOpcja == "Procesor 2")
            {
                textBox2.Text = "400";
            }
            if (wybranaOpcja == "Procesor 3")
            {
                textBox2.Text = "500";
            }


        }

        public void Komputer_Load(object sender, EventArgs e)
        {


        }

        public void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                // Jeśli tak, ustaw tekst etykiety na odpowiednią wartość
                textBox1.Text = "200";
            }
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                // Jeśli tak, ustaw tekst etykiety na odpowiednią wartość
                textBox1.Text = "300";
            }
        }
    }
}
