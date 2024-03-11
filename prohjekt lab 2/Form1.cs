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
            Komputer secondForm = new Komputer(this);
            Monitor thirdForm = new Monitor(this);
            secondForm.Show();
        }
        public void SetTextBoxTextFF1(string text1, string text2)
        {
            int liczba1Int = int.Parse(text1);
            int liczba2Int = int.Parse(text2);
            
            
            int suma = liczba1Int + liczba2Int;
            string sumaString = suma.ToString();
            textBox1.Text = sumaString;
        }

        public void SetTextBoxTextFF2(string text3)
        {
            int liczba3Int = int.Parse(text3);
            
            int liczba4Int = int.Parse((string)textBox1.Text);

            int suma2 = liczba3Int + liczba4Int;

            string sumaString2 = suma2.ToString();
            textBox1.Text = sumaString2;

        }
      //  public void SetTextBoxText(string sumaString, string )
        //{

        //}
        private void button2_Click(object sender, EventArgs e)
        {
            Monitor thirdform = new Monitor(this);
            thirdform.Show();
        }

        public void textBox1_TextChanged(object sender, EventArgs e, Komputer komputer)
       { 
        }
    }
}