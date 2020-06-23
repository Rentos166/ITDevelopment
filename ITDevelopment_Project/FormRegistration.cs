using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITDevelopment_Project
{
    public partial class FormRegistration : Form
    {
        Users user = new Users();
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem != null && textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxRepeatPassword.Text != "")
            {
                if (textBoxPassword.Text == textBoxRepeatPassword.Text)
                {
                    user.Login = textBoxLogin.Text;
                    user.Password = textBoxPassword.Text;
                    user.Type = comboBoxType.SelectedItem.ToString();
                    Program.itDb.Users.Add(user);
                    Program.itDb.SaveChanges();
                    MessageBox.Show("Пользователь успешно зарегестрирован.", "Есть контакт!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonReg_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void buttonReg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonReg.PerformClick();
        }
    }
}
