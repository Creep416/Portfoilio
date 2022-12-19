namespace Notes
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}
		private void FormMain_Load(object sender, EventArgs e)
		{

		}
		private void ButtonFill_Click(object sender, EventArgs e)
		{
			FormFill f = new FormFill();
			f.Show();
		}
        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            FormSelect f = new FormSelect();
            f.Show();
        }
    }
}