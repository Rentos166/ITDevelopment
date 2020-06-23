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
    public partial class FormAttendance : Form
    {
        void ShowAttendance()
        {
            listViewAttendance.Items.Clear();
            foreach (AttedenceSet attedenceSet in Program.itDb.AttedenceSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        attedenceSet.Id.ToString(),
                        attedenceSet.Name,
                        attedenceSet.Departament.Name,
                        attedenceSet.Price.ToString()+" руб.",
                        attedenceSet.Guarantee
                    });
                item.Tag = attedenceSet;
                listViewAttendance.Items.Add(item);
            }
            listViewAttendance.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowDepartament()
        {
            comboBoxDepartament.Items.Clear();
            foreach (Departament departmentSet in Program.itDb.Departament)
            {
                string[] item = { departmentSet.Id.ToString() + ". ", departmentSet.Name };
                comboBoxDepartament.Items.Add(string.Join(" ", item));
            }
        }
        public FormAttendance()
        {
            InitializeComponent();
            ShowAttendance();
            ShowDepartament();
        }

        private void FormAttendance_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text != "" && textBoxPrice.Text != "" && comboBoxDepartament.SelectedItem != null)
                {
                    AttedenceSet attedenceSet = new AttedenceSet();
                    attedenceSet.Name = textBoxName.Text;
                    attedenceSet.Price = Convert.ToInt32(textBoxPrice.Text);
                    attedenceSet.Guarantee = textBoxGuarantee.Text;
                    attedenceSet.IdDepartment = Convert.ToInt32(comboBoxDepartament.SelectedItem.ToString().Split('.')[0]);
                    Program.itDb.AttedenceSet.Add(attedenceSet);
                    Program.itDb.SaveChanges();
                    ShowAttendance();
                }
                else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAttendance.SelectedItems.Count == 1)
                {
                    if (textBoxName.Text != "" && textBoxPrice.Text != "" && comboBoxDepartament.SelectedItem != null)
                    {
                        AttedenceSet attedenceSet = listViewAttendance.SelectedItems[0].Tag as AttedenceSet;
                        attedenceSet.Name = textBoxName.Text;
                        attedenceSet.Price = Convert.ToInt32(textBoxPrice.Text);
                        attedenceSet.Guarantee = textBoxGuarantee.Text;
                        attedenceSet.IdDepartment = Convert.ToInt32(comboBoxDepartament.SelectedItem.ToString().Split('.')[0]);
                        Program.itDb.SaveChanges();
                        ShowAttendance();
                    }
                    else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAttendance.SelectedItems.Count == 1)
            {
                AttedenceSet attedenceSet = listViewAttendance.SelectedItems[0].Tag as AttedenceSet;
                textBoxName.Text = attedenceSet.Name;
                textBoxPrice.Text = attedenceSet.Price.ToString();
                textBoxGuarantee.Text = attedenceSet.Guarantee;
                comboBoxDepartament.SelectedIndex = comboBoxDepartament.FindString(attedenceSet.IdDepartment.ToString());
            }
            else
            {
                textBoxName.Text = "";
                textBoxPrice.Text = "";
                textBoxGuarantee.Text = "";
                comboBoxDepartament.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAttendance.SelectedItems.Count == 1)
                {
                    AttedenceSet attedenceSet = listViewAttendance.SelectedItems[0].Tag as AttedenceSet;
                    Program.itDb.AttedenceSet.Remove(attedenceSet);
                    Program.itDb.SaveChanges();
                    ShowAttendance();
                }
                textBoxName.Text = "";
                textBoxPrice.Text = "";
                textBoxGuarantee.Text = "";
                comboBoxDepartament.SelectedItem = null;
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace 
            {
                e.Handled = true;
            }
        }
    }
}
