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
        }

        private void close_info_button_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private void github_button_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Green;
            label3.Visible = true;
            Clipboard.SetText("https://github.com/Belltower182/SE-Fight-gravity");
            return;
        }

        private void email_button_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Green;
            label3.Visible = true;
            Clipboard.SetText("gregbkv@gmail.com");
            return;
        }
    }
}