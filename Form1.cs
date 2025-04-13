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
            double ve = double.Parse(exVelo.Text);
            double mi = double.Parse(minit.Text);
            double mf = double.Parse(mfinal.Text);
            double dv = ve * Math.Log(mi/mf);
            result.Text = dv.ToString();
            result.Visible = true;
        }
    }
}
