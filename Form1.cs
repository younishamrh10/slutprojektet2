namespace slutprojektet2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);
            int sum = tal1 + tal2;
            string resultat = sum.ToString();
            textBox3.Text = resultat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);
            int sum = tal1 - tal2;
            string resultat = sum.ToString();
            textBox3.Text = resultat;
        }
    }
}