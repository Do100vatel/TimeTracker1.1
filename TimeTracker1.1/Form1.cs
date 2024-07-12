namespace TimeTracker1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            form.Show();
        }
    }
}
