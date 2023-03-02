namespace Задание_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Stepen(int x, int y)
        {
            int ret = 1;
            while (y != 0)
            {
                if ((y & 1) == 1)
                    ret *= x;
                x *= x;
                y >>= 1;
            }
            return ret;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int x11 = int.Parse(x1.Text);
                int x22 = int.Parse(x2.Text);
                string resl = Convert.ToString(x11 % x22);
                res.Text = resl;

            }
            if (radioButton2.Checked)
            {
                res.Text = x1.Text+x2.Text;

            }
            if (radioButton3.Checked)
            {
                int x11 = int.Parse(x1.Text);
                int x22 = int.Parse(x2.Text);
                string resl = Convert.ToString(Stepen(x11,x22));
                res.Text = resl;

            }
            if (radioButton4.Checked)
            {
                double x11 = double.Parse(x1.Text);
                double x22 = double.Parse(x2.Text);
                string resl = Convert.ToString(x11 / x22);
                res.Text = resl;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void res_TextChanged(object sender, EventArgs e)
        {

        }
    }
}