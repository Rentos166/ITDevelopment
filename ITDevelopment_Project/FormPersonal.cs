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
    public partial class FormPersonal : Form
    {
        void ShowPersonal()
        {
            //Предварительно очищаем listView
            listViewPersonal.Items.Clear();
            //Проходимся по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach (PersonalSet personalSet in Program.itDb.PersonalSet)
            {
                Departament departamentSet = new Departament();
                foreach (Departament department in Program.itDb.Departament)
                {
                    if (personalSet.IdDepartament == department.Id)
                        departamentSet = department;
                }
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
            {
                    //указываем необходимые поля
                    personalSet.Id.ToString(),
                    personalSet.FirstName,
                    personalSet.MiddleName,
                    personalSet.LastName,
                    personalSet.Position,
                    departamentSet.Name,
                    personalSet.Phone,
                    personalSet.Email

            });
                //указываем по какому тегу будем брать элементы
                item.Tag = personalSet;
                //добавляем элементы в listView для отображения
                listViewPersonal.Items.Add(item);
            }
            listViewPersonal.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowDepartaments()
        {
            comboBoxDepartament.Items.Clear();
            foreach (Departament departments in Program.itDb.Departament)
            {
                string[] item = { departments.Id.ToString() + ". ", departments.Name };
                comboBoxDepartament.Items.Add(string.Join(" ", item));
            }
        }
        public FormPersonal()
        {
            InitializeComponent();
            ShowPersonal();
            ShowDepartaments();
        }

        private void FormPersonal_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем новый экземпляр класса Персонал
                PersonalSet personalSet = new PersonalSet();
                //Делаем ссылку на объект, который хранится в textBox-ax
                personalSet.FirstName = textBoxFirstName.Text;
                personalSet.MiddleName = textBoxMiddleName.Text;
                personalSet.LastName = textBoxLastName.Text;
                personalSet.Position = textBoxPosition.Text;
                personalSet.Phone = textBoxPhone.Text;
                personalSet.Email = textBoxEmail.Text;
                if (comboBoxDepartament.SelectedItem != null)
                    personalSet.IdDepartament = Convert.ToInt32(comboBoxDepartament.SelectedItem.ToString().Split('.')[0]);
                if (personalSet.FirstName == "" || personalSet.MiddleName == "" || personalSet.LastName == "")
                {
                    throw new Exception("Не заполнены поля ФИО");
                }
                //Добавляем в таблицу PersonalSet нового клиента personalSet
                Program.itDb.PersonalSet.Add(personalSet);
                //Сохраняем изменения в модели itDb (экземпляр которой был создан ранее)
                Program.itDb.SaveChanges();
                ShowPersonal();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPersonal.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    PersonalSet personalSet = listViewPersonal.SelectedItems[0].Tag as PersonalSet;
                    //Делаем ссылку на объект, который хранится в textBox-ax
                    personalSet.FirstName = textBoxFirstName.Text;
                    personalSet.MiddleName = textBoxMiddleName.Text;
                    personalSet.LastName = textBoxLastName.Text;
                    personalSet.Position = textBoxPosition.Text;
                    personalSet.Phone = textBoxPhone.Text;
                    personalSet.Email = textBoxEmail.Text;
                    if (comboBoxDepartament.SelectedItem != null)
                        personalSet.IdDepartament = Convert.ToInt32(comboBoxDepartament.SelectedItem.ToString().Split('.')[0]);
                    if (personalSet.FirstName == "" || personalSet.MiddleName == "" || personalSet.LastName == "")
                    {
                        throw new Exception("Не заполнены поля ФИО");
                    }
                    //Сохраняем изменения в модели itDb (экземпляр которой был создан ранее)
                    Program.itDb.SaveChanges();
                    ShowPersonal();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPersonal.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                PersonalSet personalSet = listViewPersonal.SelectedItems[0].Tag as PersonalSet;
                //указываем, что может быть изменено
                textBoxFirstName.Text = personalSet.FirstName;
                textBoxMiddleName.Text = personalSet.MiddleName;
                textBoxLastName.Text = personalSet.LastName;
                textBoxPosition.Text = personalSet.Position;
                comboBoxDepartament.SelectedIndex = comboBoxDepartament.FindString(personalSet.IdDepartament.ToString());
                textBoxPhone.Text = personalSet.Phone;
                textBoxEmail.Text = personalSet.Email;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxPosition.Text = "";
                textBoxEmail.Text = "";
                comboBoxDepartament.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если выбран 1 элемент из listView
                if (listViewPersonal.SelectedItems.Count == 1)
                {
                    //ищем этот элемент
                    PersonalSet personalSet = listViewPersonal.SelectedItems[0].Tag as PersonalSet;
                    //удаляем из модели и базы данных
                    Program.itDb.PersonalSet.Remove(personalSet);
                    //сохраняем изменения
                    Program.itDb.SaveChanges();
                    //отображаем обновленный список
                    ShowPersonal();
                }
                //очищаем textBox-ы
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxPosition.Text = "";
                textBoxEmail.Text = "";
                comboBoxDepartament.SelectedItem = null;
            }
            //если возникает какая-то ошибка, к примеру, запись используется, выводим всплывающее сообщение
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


