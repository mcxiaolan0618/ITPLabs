namespace Lab2B
{
    public partial class Lab2B : Form
    {
        public Lab2B()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lab2B_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            //changePhoto1(pb1, "Cloudy");
            changePhoto2("Cloudy");
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            //changePhoto1(pb2, "Rainy");
            changePhoto2("Rainy");
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            //changePhoto1(pb3, "Snowy");
            changePhoto2("Snowy");
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            //changePhoto1(pb4, "Sunny");
            changePhoto2("Sunny");
        }

        private void changePhoto1(PictureBox chosePictureBox, String weather) 
        {  
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = false;
            pb4.Visible = false;
            chosePictureBox.Visible = true;

            lbResult.Text = $"This is going to be a {weather} day, {txtNum1.Text}!";
        }

        private void changePhoto2(String weather)
        {
            pb1.Visible = rb1.Checked;
            pb2.Visible = rb2.Checked;
            pb3.Visible = rb3.Checked;
            pb4.Visible = rb4.Checked;
            lbResult.Text = $"This is going to be a {weather} day, {txtNum1.Text}!";
        }
    }
}
