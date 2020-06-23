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
    public partial class FormFinance : Form
    {
        void ShowFinance()
        {
            listViewFinance.Items.Clear();
            //Проходим по коллекции продуктов, которые находятся в базе с помощью foreach
            foreach (FinanceSet financeSet in Program.itDb.FinanceSet)
            {
                //Создадим новый элемент в listView с помощью массива строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    financeSet.Id.ToString(),
                    financeSet.Date.ToString("dd/MM/yyyy"),
                    financeSet.Gain.ToString(),
                    financeSet.Costs.ToString(),
                    financeSet.Profit.ToString()
                });
                item.Tag = financeSet;
                listViewFinance.Items.Add(item);
            }
            listViewFinance.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormFinance()
        {
            InitializeComponent();
            ShowFinance();
        }

        private void FormFinance_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePickerFinance.Value!= null && textBoxGains.Text != "" && textBoxCosts.Text != "")
                {
                    FinanceSet financeSet = new FinanceSet();
                    financeSet.Gain = Convert.ToInt32(textBoxGains.Text);
                    financeSet.Costs = Convert.ToInt32(textBoxCosts.Text);
                    double X;
                    X = financeSet.Gain - financeSet.Costs;
                    if (X > 0)
                    {
                        financeSet.Profit = "+" + X;
                    }
                    else if (X < 0)
                    {
                        financeSet.Profit = Convert.ToString(X);
                    }
                    else
                    {
                        financeSet.Profit = X.ToString();
                    }
                    financeSet.Date = dateTimePickerFinance.Value;
                    //Добавляем в таблицу FinanceSet новую прибыль financeSet
                    Program.itDb.FinanceSet.Add(financeSet);
                    //Сохраняем изменения в модели zokiDb (экземпляр которой был создан ранее)
                    Program.itDb.SaveChanges();
                    ShowFinance();
                }
                else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFinance.SelectedItems.Count == 1)
                {
                    if (dateTimePickerFinance.Value != null && textBoxGains.Text != "" && textBoxCosts.Text != "")
                    {
                        //создаем новый экземпляр класса Финансы
                        FinanceSet financeSet = listViewFinance.SelectedItems[0].Tag as FinanceSet;
                        financeSet.Gain = Convert.ToInt32(textBoxGains.Text);
                        financeSet.Costs = Convert.ToInt32(textBoxCosts.Text);
                        double X;
                        X = financeSet.Gain - financeSet.Costs;
                        if (X > 0)
                        {
                            financeSet.Profit = "+" + X;
                        }
                        else if (X < 0)
                        {
                            financeSet.Profit = Convert.ToString(X);
                        }
                        else
                        {
                            financeSet.Profit = X.ToString();
                        }
                        financeSet.Date = dateTimePickerFinance.Value;
                        //Сохраняем изменения в модели zokiDb (экземпляр которой был создан ранее)
                        Program.itDb.SaveChanges();
                        ShowFinance();
                    }
                    else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewFinance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFinance.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                FinanceSet financeSet = listViewFinance.SelectedItems[0].Tag as FinanceSet;
                //указываем, что может быть изменено
                textBoxGains.Text = financeSet.Gain.ToString();
                textBoxCosts.Text = financeSet.Costs.ToString();
                dateTimePickerFinance.Value = financeSet.Date;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxGains.Text = "";
                textBoxCosts.Text = "";
                dateTimePickerFinance.Value = DateTime.Now;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFinance.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    FinanceSet financeSet = listViewFinance.SelectedItems[0].Tag as FinanceSet;
                    Program.itDb.FinanceSet.Remove(financeSet);
                    Program.itDb.SaveChanges();
                    ShowFinance();
                }
                dateTimePickerFinance.Value = DateTime.Now;
                textBoxGains.Text = "";
                textBoxCosts.Text = "";
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBoxGains_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace 
            {
                e.Handled = true;
            }
        }
    }
}
