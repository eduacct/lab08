namespace lab08_swe_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {
            try {
                if (exVelo.Text == "0" || minit.Text == "0" || mfinal.Text == "0")
                {
                    MessageBox.Show("Cannot be zero");
                }
                double ve = double.Parse(exVelo.Text);
                double mi = double.Parse(minit.Text);
                double mf = double.Parse(mfinal.Text);
                double dv = ve * Math.Log(mi / mf);
                result.Text = dv.ToString();
                result.Visible = true;
            }
            catch {
                MessageBox.Show("Invalid Input");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
