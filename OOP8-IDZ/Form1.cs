namespace OOP8_IDZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int n = int.Parse(textBox3.Text);
            int r = int.Parse(textBox4.Text);
            double result = 0;
            double chisl = 0;
            if (radioButton1.Checked)
            {
                for (int i = 1; i <= n; i++)
                {
                    double znam = i;
                    if (i % 2 == 0)
                        chisl = chisl + (Math.Pow(y, (i-1)));
                    else
                        chisl = chisl - (Math.Pow(x, (i-1)));
                    result += chisl / znam;
                    chisl = 0;
                }
                textBox5.Text= result.ToString();
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; i <= r; i++)
                    {
                        result += (j * j + i) / (Math.Pow(i, j) + j);
                    }
                }
                textBox5.Text = result.ToString();
            }
        }
    }
}