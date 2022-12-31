namespace SE_Fight_Gravity
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Nothing To Initiate At Start.
        }

        private void ButtonInfoCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkToGithubClick(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Green;
            label3.Visible = true;
            Clipboard.SetText("https://github.com/Belltower182/SE-Fight-gravity");
        }

        private void LinkForEmailButtonClick(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Green;
            label3.Visible = true;
            Clipboard.SetText("gregbkv@gmail.com");
        }

        private void LinkToDonateButtonClick(object sender, EventArgs e)
        {
            Donate donate = new Donate();
            donate.Show();
        }
    }
}