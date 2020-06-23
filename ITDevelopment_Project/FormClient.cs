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
    public partial class FormClients : Form
    {
        void ShowClient()
        {
            //Предварительно очищаем listView
            listViewClient.Items.Clear();
            //Проходимся по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach (ClientSet clientsSet in Program.itDb.ClientSet)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    clientsSet.Id.ToString(),
                    clientsSet.FirstName,
                    clientsSet.MiddleName,
                    clientsSet.LastName,
                    clientsSet.CompanyName,
                    clientsSet.Phone,
                    clientsSet.Email
                });
                //указываем по какому тегу будем брать элементы
                item.Tag = clientsSet;
                //добавляем элементы в listView для отображения
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormClients()
        {
            InitializeComponent();
            ShowClient();
        }

        private void FormClients_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем новый экземпляр класса Клиент
                ClientSet clientsSet = new ClientSet();
                //Делаем ссылку на объект, который хранится в textBox-ax
                clientsSet.FirstName = textBoxFirstName.Text;
                clientsSet.MiddleName = textBoxMiddleName.Text;
                clientsSet.LastName = textBoxLastName.Text;
                clientsSet.CompanyName = textBoxCompany.Text;
                clientsSet.Phone = textBoxPhone.Text;
                clientsSet.Email = textBoxEmail.Text;  
                //Добавляем в таблицу ClientSet нового клиента clientSet
                Program.itDb.ClientSet.Add(clientsSet);
                //Сохраняем изменения в модели itDb (экземпляр которой был создан ранее)
                Program.itDb.SaveChanges();
                ShowClient();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //условие, если в listView выбран 1 элемент
                if (listViewClient.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    ClientSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                    //указываем, что может быть изменено
                    clientsSet.FirstName = textBoxFirstName.Text;
                    clientsSet.MiddleName = textBoxMiddleName.Text;
                    clientsSet.LastName = textBoxLastName.Text;
                    clientsSet.CompanyName = textBoxCompany.Text;
                    clientsSet.Phone = textBoxPhone.Text;
                    clientsSet.Email = textBoxEmail.Text; 
                    //Сохраняем изменения в модели itDb (экземпляр которой был создан ранее)
                    Program.itDb.SaveChanges();
                    ShowClient();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                //если выбран 1 элемент из listView
                if (listViewClient.SelectedItems.Count == 1)
                {
                    //ищем этот элемент
                    ClientSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                    //удаляем из модели и базы данных
                    Program.itDb.ClientSet.Remove(clientsSet);
                    //сохраняем изменения
                    Program.itDb.SaveChanges();
                    //отображаем обновленный список
                    ShowClient();
                }
                //очищаем textBox-ы
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxCompany.Text = "";
            }
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //условие, если выбран 1 элемент
            if (listViewClient.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                ClientSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                //указываем, что может быть изменено
                textBoxFirstName.Text = clientsSet.FirstName;
                textBoxMiddleName.Text = clientsSet.MiddleName;
                textBoxLastName.Text = clientsSet.LastName;
                textBoxCompany.Text = clientsSet.CompanyName;
                textBoxPhone.Text = clientsSet.Phone;
                textBoxEmail.Text = clientsSet.Email;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxCompany.Text = "";
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace 
            {
                e.Handled = true;
            }
        }
    }
}
