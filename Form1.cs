namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void quit_Click(object sender, EventArgs e)
        {

        }

        private void checkbtn_click(object sender, EventArgs e)
        {
            telenum_form newform = new telenum_form();
            newform.Show();

        }

        private void new_member(object sender, EventArgs e)
        {
            Form3 newform3 = new Form3();
            newform3.Show();
        }

        private void edit_event(object sender, EventArgs e)
        {

        }
    }
}