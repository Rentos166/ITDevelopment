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
    }
}
