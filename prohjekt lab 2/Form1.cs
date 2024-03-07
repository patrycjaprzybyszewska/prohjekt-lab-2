namespace prohjekt_lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Komputer secondForm = new Komputer();
            secondForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Monitor thirdform = new Monitor();
            thirdform.Show();
        }
    }
}