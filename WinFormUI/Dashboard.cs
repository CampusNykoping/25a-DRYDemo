namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void generateEmployeeIdButton_Click(object sender, EventArgs e)
        {
            string employeeId = $@"{ firstNameText.Text.Substring(0, 4) }{ lastNameText.Text.Substring(0, 4) }{ DateTime.Now.Millisecond }";
            employeeIdText.Text = employeeId;
        }
    }
}