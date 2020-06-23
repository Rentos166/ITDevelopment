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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if(FormAuthorization.users.type!="Директор")
            {
                buttonOpenPersonal.Enabled = false;
            }
            else
            {
                buttonOpenPersonal.Enabled = true;
            }
            labelHello.Text = "Приветствую, " + FormAuthorization.users.type +", " + FormAuthorization.users.login;
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClients();
            formClient.Show();
        }

        private void buttonOpenPersonal_Click(object sender, EventArgs e)
        {
            Form formPersonal = new FormPersonal();
            formPersonal.Show();
        }

        private void buttonOpenDepartment_Click(object sender, EventArgs e)
        {
            Form formDepartment = new FormDepartament();
            formDepartment.Show();
        }

        private void buttonOpenAttendance_Click(object sender, EventArgs e)
        {
            Form formAttendance = new FormAttendance();
            formAttendance.Show();
        }

        private void buttonOpenCustom_Click(object sender, EventArgs e)
        {
            Form formCustoms = new FormCustoms();
            formCustoms.Show();
        }

        private void buttonOpenSeminars_Click(object sender, EventArgs e)
        {
            Form formSeminars = new FormSeminars();
            formSeminars.Show();
        }

        private void buttonOpenFinance_Click(object sender, EventArgs e)
        {
            Form formFinance = new FormFinance();
            formFinance.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            
            Form formAuthorization = new FormAuthorization();
            formAuthorization.Show();
            Close();
        }

        private void buttonExit_MouseMove(object sender, MouseEventArgs e)
        {
            buttonExit.BackColor = Color.MediumSpringGreen;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.DarkGreen;
        }
    }
}
