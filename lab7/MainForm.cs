using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class MainForm : Form
    {
        private string[] names = new string[] { "Василий", "Станислав", "Дмитрий", "Даниил", "Алексей", "Виктор", "Евгений", "Анатолий" };
        private string[] surnames = new string[] { "Данильченко", "Карпов", "Линник", "Шевцов", "Серов", "Волков", "Шлеменко", "Потапов" };
        private string[] patronymics = new string[] { "Петрович", "Станиславович", "Дмитриевич", "Александрович", "Юрьевич", "Денисович", "Олегович", "Иванович" };
        private string[] cathedras = new string[] { "Экономики", "Физики", "Математики", "Информационной безопасности", "Компьютерных систем", "Промышленного строительства" };
        private string[] positions = new string[] { "Профессор", "Доцент", "Старший преподаватель", "Преподаватель", "Ассистент" };
        public List<Teacher> list = new List<Teacher>();
        int id, experience, salary;
        string name, surname, patronymic, cathedra, position;
        DateTime birth_date;
        Random rd = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            if (numericUpDown_size.Value <= 0)
            {
                MessageBox.Show("Incorrect size!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < (int)numericUpDown_size.Value; i++)
            {
                id = i;
                name = names[rd.Next(0, names.Length)];
                surname = surnames[rd.Next(0, surnames.Length)];
                patronymic = patronymics[rd.Next(0, patronymics.Length)];
                birth_date = new DateTime(rd.Next(1950, 1995), rd.Next(1, 12), rd.Next(1, 28));
                cathedra = cathedras[rd.Next(0, cathedras.Length)];
                position = positions[rd.Next(0, positions.Length)];
                experience = rd.Next(1, 40);
                salary = rd.Next(6000, 20000);
                list.Add(new Teacher(id, name, surname, patronymic, birth_date, cathedra, position, experience, salary));
            }
            dgv_add(ref dataGridView_info);
        }
        private void dgv_add(ref DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 9;
            dgv.RowCount = (int)numericUpDown_size.Value;
            dgv.Columns[0].Width = 30;
            dgv.Columns[1].Width = 60;
            dgv.Columns[2].Width = 90;
            dgv.Columns[3].Width = 90;
            dgv.Columns[4].Width = 70;
            dgv.Columns[5].Width = 80;
            dgv.Columns[6].Width = 80;
            dgv.Columns[7].Width = 50;
            dgv.Columns[8].Width = 50;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "Имя";
            dgv.Columns[2].HeaderText = "Фамилия";
            dgv.Columns[3].HeaderText = "Отчество";
            dgv.Columns[4].HeaderText = "Дата рождения";
            dgv.Columns[5].HeaderText = "Кафедра";
            dgv.Columns[6].HeaderText = "Должность";
            dgv.Columns[7].HeaderText = "Стаж работы";
            dgv.Columns[8].HeaderText = "Зарплата";
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv[0, i].Value = list[i].id;
                dgv[1, i].Value = list[i].name;
                dgv[2, i].Value = list[i].surname;
                dgv[3, i].Value = list[i].patronymic;
                dgv[4, i].Value = list[i].birth_date.ToShortDateString();
                dgv[5, i].Value = list[i].cathedra;
                dgv[6, i].Value = list[i].position;
                dgv[7, i].Value = list[i].experience;
                dgv[8, i].Value = list[i].salary;
            } 
        }
        private void button_info_Click(object sender, EventArgs e)
        {
            InformationForm f = new InformationForm();
            f.ShowDialog();
        }

        private void button_op_Click(object sender, EventArgs e)
        {
            if(list.Count == 0)
            {
                MessageBox.Show("Please, create a list!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OperationsForm of = new OperationsForm(list);
            of.ShowDialog();
        }
    }
}
