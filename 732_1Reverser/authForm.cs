using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _732_1Reverser
{
    public partial class authForm : Form
    {
        private bool is_authed = false;
        private MainForm parent_form;
        private DBWorker dbworker;

        public authForm(MainForm parent_form, DBWorker dbworker)
        {
            InitializeComponent();
            this.parent_form = parent_form;
            this.dbworker = dbworker;
        }

        private void authForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!is_authed)
            {
                dbworker.DisconnectDB();
                Application.Exit();
            }
        }

        

        private void authEnterB_Click(object sender, EventArgs e)
        {
            string login_text = authLoginTB.Text;
            string pwd_text = authPwdTB.Text;

            if (dbworker.AuthUser(login_text, pwd_text))
            {
                parent_form.UserAuthed();
                is_authed = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Неправильный логин или пароль!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void authGoReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            regForm registration = new regForm(dbworker);
            registration.ShowDialog();
        }
    }
}
