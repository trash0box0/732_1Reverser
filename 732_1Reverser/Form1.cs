namespace _732_1Reverser
{
    public partial class MainForm : Form
    {
        private bool is_authed = false;
        private ReverseManager reverseManager = new ReverseManager();

        public MainForm()
        {
            InitializeComponent();
            Output.Text = "";

            Opacity = 0;
            ShowInTaskbar = false;
        }

        public void UserAuthed()
        {
            Opacity = 100;
            ShowInTaskbar = true;
            is_authed = true;
            this.Activate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            string str = InputTextBox.Text;
            if (str.Length > 0)
            {
                str = reverseManager.Reverse(str);
            }
            else
                return;

            Output.Text = str;

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (is_authed)
            {
                DialogResult result = MessageBox.Show("Точно хотите закрыть?", "Вы уверены?", MessageBoxButtons.YesNo);

                bool needClose = result == DialogResult.Yes;

                if (!needClose)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}