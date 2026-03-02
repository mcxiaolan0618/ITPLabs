namespace Lab2C
{
    public partial class Lab2C : Form
    {
        public Lab2C()
        {
            InitializeComponent();
        }

        private void frm2C_Load(object sender, EventArgs e)
        {
            lstStudents.Items.Add("Mary Chu");
            lstStudents.Items.Add("Peter Lee");
            lstStudents.Items.Add("Johnson Chan");
            lstStudents.Items.Add("Alex Leung");
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Add(txtNum1.Text);
            txtNum1.Text = "";
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbResult.Text = $"The following item is selected: {lstStudents.SelectedItem}";
        }

        private void lstStudents_DoubleClick(object sender, EventArgs e)
        {
            lbResult.Text = $"The following item is deleted:  {lstStudents.SelectedItem}";
            lstStudents.Items.Remove(lstStudents.SelectedItem);
        }
    }
}
