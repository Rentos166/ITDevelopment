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
    public partial class FormCustoms : Form
    {
        void ShowCustoms()
        {
            listViewCustoms.Items.Clear();
            foreach (CustomSet customSet in Program.itDb.CustomSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    customSet.Id.ToString(),
                    customSet.ClientSet.LastName +" "+customSet.ClientSet.FirstName.Remove(1) +". "+ customSet.ClientSet.MiddleName.Remove(1)+" .",
                    customSet.ClientSet.CompanyName,
                    customSet.ClientSet.Phone,
                    customSet.Departament.Name,
                    customSet.AttedenceSet.Name,
                    customSet.DeadLine.ToString(),
                    customSet.Status
                });
                item.Tag = customSet;
                listViewCustoms.Items.Add(item);
            }
            listViewCustoms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowClient()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientSet client in Program.itDb.ClientSet)
            {
                string[] item = { client.Id.ToString() + ". ", client.LastName + " " + client.FirstName.Remove(1) + ". " + client.MiddleName.Remove(1) + " ." };
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDepartment()
        {
            comboBoxDepartment.Items.Clear();
            foreach (Departament departments in Program.itDb.Departament)
            {
                string[] item = { departments.Id.ToString() + ". ", departments.Name };
                comboBoxDepartment.Items.Add(string.Join(" ", item));
            }
        }
        void ShowAttendance()
        {
            comboBoxAttendance.Items.Clear();
            foreach (AttedenceSet attens in Program.itDb.AttedenceSet)
            {
                string[] item = { attens.Id.ToString() + ". ", attens.Name };
                comboBoxAttendance.Items.Add(string.Join(" ", item));
            }
        }
        public FormCustoms()
        {
            InitializeComponent();
            ShowCustoms();
            ShowClient();
            ShowDepartment();
            ShowAttendance();
        }

        private void FormCustoms_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxClients.SelectedItem != null && comboBoxDepartment.SelectedItem != null
                    && comboBoxAttendance.SelectedItem != null && dateTimePickerDead.Value != null && textBoxStatus.Text != "")
                {
                    CustomSet customSet = new CustomSet();
                    customSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    customSet.IdDepartament = Convert.ToInt32(comboBoxDepartment.SelectedItem.ToString().Split('.')[0]);
                    customSet.IdAttedence = Convert.ToInt32(comboBoxAttendance.SelectedItem.ToString().Split('.')[0]);
                    customSet.DeadLine = dateTimePickerDead.Value;
                    customSet.Status = textBoxStatus.Text;
                    Program.itDb.CustomSet.Add(customSet);
                    Program.itDb.SaveChanges();
                    ShowCustoms();
                }
                else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCustoms.SelectedItems.Count == 1)
                {
                    if (comboBoxClients.SelectedItem != null && comboBoxDepartment.SelectedItem != null
                   && comboBoxAttendance.SelectedItem != null && dateTimePickerDead.Value != null && textBoxStatus.Text != "")
                    {
                        CustomSet customSet = listViewCustoms.SelectedItems[0].Tag as CustomSet;
                        customSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                        customSet.IdDepartament = Convert.ToInt32(comboBoxDepartment.SelectedItem.ToString().Split('.')[0]);
                        customSet.IdAttedence = Convert.ToInt32(comboBoxAttendance.SelectedItem.ToString().Split('.')[0]);
                        customSet.DeadLine = dateTimePickerDead.Value;
                        customSet.Status = textBoxStatus.Text;
                        Program.itDb.SaveChanges();
                        ShowCustoms();
                    }
                }
                else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewCustoms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCustoms.SelectedItems.Count == 1)
            {
                CustomSet customSet = listViewCustoms.SelectedItems[0].Tag as CustomSet;
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(customSet.IdClient.ToString());
                comboBoxDepartment.SelectedIndex = comboBoxDepartment.FindString(customSet.IdDepartament.ToString());
                comboBoxAttendance.SelectedIndex = comboBoxAttendance.FindString(customSet.IdAttedence.ToString());
                dateTimePickerDead.Value = customSet.DeadLine;
                textBoxStatus.Text = customSet.Status;
            }
            else
            {
                comboBoxClients.SelectedItem = null;
                comboBoxDepartment.SelectedItem = null;
                comboBoxAttendance.SelectedItem = null;
                dateTimePickerDead.Value = DateTime.Now;
                textBoxStatus.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCustoms.SelectedItems.Count == 1)
                {
                    CustomSet customSet = listViewCustoms.SelectedItems[0].Tag as CustomSet;
                    Program.itDb.CustomSet.Remove(customSet);
                    Program.itDb.SaveChanges();
                    ShowCustoms();
                }
                comboBoxClients.SelectedItem = null;
                comboBoxDepartment.SelectedItem = null;
                comboBoxAttendance.SelectedItem = null;
                dateTimePickerDead.Value = DateTime.Now;
                textBoxStatus.Text = "";
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}



