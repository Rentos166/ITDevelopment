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
    public partial class FormSeminars : Form
    {
        void ShowSeminar()
        {
            listViewSeminar.Items.Clear();
            foreach(SeminarsSet seminarsSet in Program.itDb.SeminarsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    seminarsSet.Id.ToString(),
                    seminarsSet.Name,
                    "г. " + seminarsSet.Address_City+", " + "ул. " + seminarsSet.Address_Street+", "+
                    "д. " + seminarsSet.Address_House,
                    seminarsSet.Date.ToString("dd/MM/yyyy")
                });
                item.Tag = seminarsSet;
                listViewSeminar.Items.Add(item);
            }
            listViewSeminar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormSeminars()
        {
            InitializeComponent();
            ShowSeminar();
        }

        private void FormSeminars_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxTypeSeminar.SelectedItem!=null && textBoxAddress_City.Text !="" && textBoxAddress_Street.Text != "" && textBoxAddress_House.Text != "" && dateTimePickerSeminar.Value != null )
                {
                    SeminarsSet seminarsSet = new SeminarsSet();
                    seminarsSet.Address_City = textBoxAddress_City.Text;
                    seminarsSet.Address_Street = textBoxAddress_Street.Text;
                    seminarsSet.Address_House = textBoxAddress_House.Text;
                    seminarsSet.Date = dateTimePickerSeminar.Value;
                    seminarsSet.Name = comboBoxTypeSeminar.SelectedItem.ToString();
                    Program.itDb.SeminarsSet.Add(seminarsSet);
                    Program.itDb.SaveChanges();
                    ShowSeminar();
                }
                else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSeminar.SelectedItems.Count == 1)
                {
                    if (comboBoxTypeSeminar.SelectedItem != null && textBoxAddress_City.Text != "" && textBoxAddress_Street.Text != "" && textBoxAddress_House.Text != "" && dateTimePickerSeminar.Value != null)
                    {
                        SeminarsSet seminarsSet = listViewSeminar.SelectedItems[0].Tag as SeminarsSet;
                        seminarsSet.Address_City = textBoxAddress_City.Text;
                        seminarsSet.Address_Street = textBoxAddress_Street.Text;
                        seminarsSet.Address_House = textBoxAddress_House.Text;
                        seminarsSet.Date = dateTimePickerSeminar.Value;
                        seminarsSet.Name = comboBoxTypeSeminar.SelectedItem.ToString();
                        Program.itDb.SaveChanges();
                        ShowSeminar();
                    }
                    else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewSeminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSeminar.SelectedItems.Count == 1)
            {
                SeminarsSet seminarsSet = listViewSeminar.SelectedItems[0].Tag as SeminarsSet;
                textBoxAddress_City.Text = seminarsSet.Address_City;
                textBoxAddress_Street.Text = seminarsSet.Address_Street;
                textBoxAddress_House.Text = seminarsSet.Address_House;
                dateTimePickerSeminar.Value = seminarsSet.Date;
                comboBoxTypeSeminar.SelectedIndex = comboBoxTypeSeminar.FindString(seminarsSet.Name);
            }
            else
            {
                textBoxAddress_City.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_House.Text = "";
                dateTimePickerSeminar.Value = DateTime.Now;
                comboBoxTypeSeminar.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSeminar.SelectedItems.Count == 1)
                {
                    SeminarsSet seminarsSet = listViewSeminar.SelectedItems[0].Tag as SeminarsSet;
                    Program.itDb.SeminarsSet.Remove(seminarsSet);
                    Program.itDb.SaveChanges();
                    ShowSeminar();
                }
                textBoxAddress_City.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_House.Text = "";
                dateTimePickerSeminar.Value = DateTime.Now;
                comboBoxTypeSeminar.SelectedItem = null;
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
