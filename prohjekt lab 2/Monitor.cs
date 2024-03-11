using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prohjekt_lab_2
{
    public partial class Monitor : Form
    {
        private Form1 form2;
        public Monitor(Form1 form2)
        {
            InitializeComponent();
            InitializeListView();

            this.form2 = form2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Nazwa", "Cena");
            AddItemToListView("Monitor 1", "300");
            AddItemToListView("Monitor2", "400");
            AddItemToListView("Monitor 3", "500");
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        }

        private void AddItemToListView(string nazwa, string cena)
        {
            string[] row = { nazwa, cena };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


            string wybranaOpcja1 = listView1.SelectedItems[0].Text;
            if (wybranaOpcja1 == "Monitor 1")
            {
                textBox1.Text = "300";
            }
            if (wybranaOpcja1 == "Monitor2")
            {
                textBox1.Text = "400";
            }
            if (wybranaOpcja1 == "Monitor 3")
            {
                textBox1.Text = "500";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            form2.SetTextBoxTextFF2(textBox1.Text);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
