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
    public partial class regForm : Form
    {
        private DBWorker dbworker;

        public regForm(DBWorker dbworker)
        {
            InitializeComponent();
            this.dbworker = dbworker;
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string login = regLoginTB.Text;
            string pwd1 = regPwd1TB.Text;
            string pwd2 = regPwd2TB.Text;

            if (pwd1 != pwd2)
            {
                MessageBox.Show("Пароли не совпадают");
            }
            else
            {
                if (dbworker.AddNewUser(login, pwd1) == true)
                {
                    MessageBox.Show("Зарегистрирован");
                }
            }
        }
    }
}
