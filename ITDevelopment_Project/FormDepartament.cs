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
    public partial class FormDepartament : Form
    {
        void ShowDepartament()
        {
            // Предварительно очищаем
            listViewDepartament.Items.Clear();
            //Проходимся по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach (Departament departamentSet in Program.itDb.Departament)
            {
                Deductions(departamentSet);
                ListViewItem item = new ListViewItem(new string[]
                {
                    departamentSet.Id.ToString(),
                    departamentSet.Name,
                    departamentSet.Count.ToString(),
                    departamentSet.Manager
                });
                item.Tag = departamentSet;
                listViewDepartament.Items.Add(item);
            }
            listViewDepartament.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void Deductions(Departament departament)
        {
            int count = 0;
            foreach(PersonalSet personalSet in Program.itDb.PersonalSet)
            {
                if(personalSet.IdDepartament == departament.Id)
                {
                    count++;
                }
                departament.Count = count;
            }
        }
        public FormDepartament()
        {
            InitializeComponent();
            ShowDepartament();
        }

        private void FormDepartament_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNameCompany.Text != "")
                {
                    Departament departmentsSet = new Departament();
                    departmentsSet.Name = textBoxNameCompany.Text;
                    departmentsSet.Manager = textBoxManager.Text;
                    Program.itDb.Departament.Add(departmentsSet);
                    Program.itDb.SaveChanges();
                    ShowDepartament();
                }
                else MessageBox.Show("Заполните название отдела!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDepartament.SelectedItems.Count == 1)
                {
                    if (textBoxNameCompany.Text != "")
                    {
                        Departament departmentsSet = listViewDepartament.SelectedItems[0].Tag as Departament;
                        departmentsSet.Name = textBoxNameCompany.Text;
                        departmentsSet.Manager = textBoxManager.Text;
                        Program.itDb.SaveChanges();
                        ShowDepartament();
                    }
                    else MessageBox.Show("Заполните название отдела!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewDepartament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDepartament.SelectedItems.Count == 1)
            {
                Departament departmentsSet = listViewDepartament.SelectedItems[0].Tag as Departament;
                textBoxNameCompany.Text = departmentsSet.Name;
                textBoxManager.Text = departmentsSet.Manager;
            }
            else
            {
                textBoxNameCompany.Text = "";
                textBoxManager.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDepartament.SelectedItems.Count == 1)
                {
                    Departament departmentsSet = listViewDepartament.SelectedItems[0].Tag as Departament;
                    Program.itDb.Departament.Remove(departmentsSet);
                    Program.itDb.SaveChanges();
                }
                textBoxNameCompany.Text = "";
                textBoxManager.Text = "";
                ShowDepartament();
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
